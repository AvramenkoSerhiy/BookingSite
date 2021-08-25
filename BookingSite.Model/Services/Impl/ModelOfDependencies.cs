using BookingSite.Model.Services.Abstr;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Services.Impl
{
    public static class ModelOfDependencies
    {
        public static IServiceCollection SetModelOfDependencies(this IServiceCollection services)
        {
            services.AddScoped<IServiceOfBooking, ServiceOfBooking>();
            services.AddScoped<IServiceOfStore, ServiceOfStore>();
            services.AddScoped<IServiceOfProduct, ServiceOfProduct>();
            services.AddScoped<IServiceOfTypeOfProduct, ServiceOfTypeOfProduct>();
            return services;
        }
    }
}
