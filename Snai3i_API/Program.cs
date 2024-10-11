
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Snai3i_BLL.Automapping;
using Snai3i_BLL.Manager.Acountmanager;
using Snai3i_BLL.Manager.CraftsManager;
using Snai3i_BLL.Manager.OrdersManager;
using Snai3i_BLL.Manager.ReviewsManager;
using Snai3i_DAL.Data.Context;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.CraftsRepository;
using Snai3i_DAL.Data.Repository.GenericRepository;
using Snai3i_DAL.Data.Repository.OrdersRepository;
using Snai3i_DAL.Data.Repository.ReviewsRepository;
using Snai3i_DAL.Data.Repository.SalesRepository;
using Snai3i_DAL.Data.Repository.UnitOfWork;
using Snai3i_DAL.Data.Repository.UserWorkerTransactionUnitOfWork;
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


            // register genericrepositroy 
            builder.Services.AddScoped( typeof(IGenericRepository<>) , typeof(GenericRepository<>) );
            // to deduce type of entity in geenric repositroy when injected in cotroller 

            // register of sales repository 
            builder.Services.AddScoped<IsalesRepository, SalesRepository>();
            builder.Services.AddScoped<IReviewsRepository, ReviewsRepositoryy>();
            builder.Services.AddScoped<IOrdersRepository, OrdersRepositoryy>();
            builder.Services.AddScoped<ICraftRepo, CraftRepo>();

            builder.Services.AddScoped<IUserWorkerTransactionUnitOfWork, UserWorkerTransactionUnitOfWork>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddScoped<IReviewManager, ReviewManager>();
            builder.Services.AddScoped<IOrderManager, OrderManager>();
            builder.Services.AddScoped<ICraftManger, CraftManger>();

            // register identity user // you better write identityrole with the way shown below 
            builder.Services.AddIdentity<ApplicationUser, Microsoft.AspNetCore.Identity.IdentityRole>().
                AddEntityFrameworkStores<SnaiiDBContext>();

            // register acountmanager 

            builder.Services.AddScoped<IAccountManager, AccountManager>(); 


            // register automapper 

            builder.Services.AddAutoMapper(map => map.AddProfile( new MapperProfile() ) ); 

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


            app.MapControllers();

            app.Run();
        }
    }
}
