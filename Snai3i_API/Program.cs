
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Snai3i_DAL.Data.Context;
using Snai3i_DAL.Data.Repository.GenericRepository;
using Snai3i_DAL.Data.Repository.SalesRepository;

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

            // register genericrepositroy 
            builder.Services.AddScoped( typeof(IGenericRepository<>) , typeof(GenericRepository<>) );
            // to deduce type of entity in geenric repositroy when injected in cotroller 

            // register of sales repository 
            builder.Services.AddScoped<IsalesRepository, SalesRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
