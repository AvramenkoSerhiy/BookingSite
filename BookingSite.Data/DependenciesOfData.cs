using BookingSite.Data.Repositories.Abstr;
using BookingSite.Data.Repositories.Impl;
using BookingSite.Data.UOW.Abstr;
using BookingSite.Data.UOW.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data
{
    public static class DependenciesOfData
    {
        public static IServiceCollection SetDependenciesOfData(this IServiceCollection services)
        {
            services.AddScoped<DBContextOfApp>();
            services.AddScoped<IRepositoryOfBooking, RepositoryOfBooking>();
            services.AddScoped<IRepositoryOfDurationOfBooking, RepositoryOfDurationOfBooking>();
            services.AddScoped<IRepositoryOfProduct, RepositoryOfProduct>();
            services.AddScoped<IRepositoryOfTypeOfProduct, RepositoryOfTypeOfProduct>();
            services.AddScoped<IRepositoryOfStore, RepositoryOfStore>();
            services.AddScoped<IUOW, UnitOW>();
            return services;
        }
    }
}
