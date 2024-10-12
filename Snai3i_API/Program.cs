
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Snai3i_API.Hubs;
using Snai3i_BLL.Automapping;
using Snai3i_BLL.Manager.Acountmanager;
using Snai3i_BLL.Manager.SizesManager;
using Snai3i_BLL.Manager.ToolsManager;
using Snai3i_DAL.Data.Context;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.GenericRepository;
using Snai3i_DAL.Data.Repository.SalesRepository;
using Snai3i_DAL.Data.Repository.service;
using Snai3i_DAL.Data.Repository.SizesRepository;
using Snai3i_DAL.Data.Repository.ToolsRepository;
using Snai3i_DAL.Data.Repository.UnitOfWork;
using System.Text;

namespace Snai3i_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // register SnaiiDBContext 
            builder.Services.AddDbContext<SnaiiDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("CS"));
            }
                );

            // register authorization 

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JWT";
                options.DefaultChallengeScheme = "JWT";

            }
            ).AddJwtBearer("JWT", options =>
            {
                var secretkeyString = builder.Configuration.GetValue<string>("SK");
                var securityKeyBytes = Encoding.ASCII.GetBytes(secretkeyString);
                SecurityKey securitykey = new SymmetricSecurityKey(securityKeyBytes);

                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    IssuerSigningKey = securitykey,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };

            });

            // register fileservice 

            builder.Services.AddTransient<Ifileservice, FileService>();

            // register genericrepositroy 
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            // to deduce type of entity in geenric repositroy when injected in cotroller 

            // register of sales repository 
            builder.Services.AddScoped<IsalesRepository, SalesRepository>();

            // register identity user // you better write identityrole with the way shown below 
            builder.Services.AddIdentity<ApplicationUser, Microsoft.AspNetCore.Identity.IdentityRole>(
                    options =>
                    {
                        options.Password.RequireNonAlphanumeric = false;
                        options.Password.RequireLowercase = false;
                        options.Password.RequireUppercase = false;
                        options.Password.RequiredLength = 5;
                    }


                ).
                AddEntityFrameworkStores<SnaiiDBContext>();

            // register acountmanager 

            builder.Services.AddScoped<IAccountManager, AccountManager>();


            // register automapper 

            builder.Services.AddAutoMapper(map => map.AddProfile(new MapperProfile()));

            // register of Tool repository
            builder.Services.AddScoped<IToolRepository, ToolRepository>();
            builder.Services.AddScoped<ISizeRepository, SizeRepository>();

            // register of Unit of work repository
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddScoped<IToolManager, ToolManager>();
            builder.Services.AddScoped<ISizeManager, SizeManager>();

            //builder.Services.AddScoped<ICraftManger, CraftManger>();
            builder.Services.AddSignalR();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapHub<ChatHub>("/chat");//it take class name and you give it the url 
            app.MapControllers();

            app.Run();
        }


        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            foreach (var role in Enum.GetValues(typeof(usertype)).Cast<usertype>())
            {
                string roleName = role.ToString();
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}
