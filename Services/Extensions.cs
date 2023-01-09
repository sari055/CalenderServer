using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using Repository.Repositories;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Entities;
using Services.Model;
using Microsoft.AspNetCore.Http;

namespace Services
{
    public static class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            MapperConfiguration config = new MapperConfiguration(
               conf => conf.CreateMap<User, UserModel>()
               .ReverseMap());

            IMapper mapper = config.CreateMapper();


            services.AddSingleton(mapper);

            services.AddDbContext<IDataSource, SqlDataSource>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
    }
}
