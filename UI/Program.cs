using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Services;
using Services.Interfaces;
using Services.ServiceClasses;

namespace UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add services to the container.
            builder.Services.AddScoped<IDescendantService, DescendantService>();
            //builder.Services.AddScoped<IDescendantImageService, DescendantImageService>();
            //builder.Services.AddScoped<IImageService, ImageService>();
            //builder.Services.AddScoped<ISpecialDateService, SpecialDateService>();
            //builder.Services.AddScoped<ISpecialEventService, SpecialEventService>();
            builder.Services.AddScoped<IUserService, UserService>();



           // builder.Services.AddDbContext<IDataSource, SqlDataSource>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyProjectDB;Trusted_Connection=True;"));

            builder.Services.AddRepoDependencies();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

           builder.Services.AddTransient< IDescendantRepository,DescendantRepository>();

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
            //builder.Services.AddScoped<IDescendantRepository, DescendantRepository>();
            //builder.Services.AddScoped<IDescendantImageRepository, DescendantImageRepository>();
            //builder.Services.AddScoped<IImageRepository, ImageRepository>();
            //builder.Services.AddScoped<ISpecialDateRepository, SpecialDateRepository>();
            //builder.Services.AddScoped<ISpecialEventRepository, SpecialEventRepository>();
            //builder.Services.AddScoped<IUserRepository, UserRepository>();

           
            //builder.Services.AddTransient<IDescendantService, DescendantService>();
            //builder.Services.AddTransient<IDescendantImageService, DescendantImageService>();
            //builder.Services.AddTransient<IImageService, ImageService>();
            //builder.Services.AddTransient<ISpecialDateService, SpecialDateService>();
            //builder.Services.AddTransient<ISpecialEventService, SpecialEventService>();
            //builder.Services.AddTransient<IUserService, UserService>();
        }
    }
}