using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.ConsoleV
{
    static class DependenciesOfConsole
    {
        static IServiceCollection SetDependenciesOfConsole(this IServiceCollection services)
        {
            services.AddScoped<PageOfBooking>();
            services.AddScoped<PageOfProduct>();
            services.AddScoped<PageOfStore>();
            services.AddScoped<PageOfTypeOfProduct>();
            services.AddScoped<SelectedItems>();
            return services;
        }
    }
}
