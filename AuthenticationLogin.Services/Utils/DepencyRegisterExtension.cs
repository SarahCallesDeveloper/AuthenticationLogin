using AuthenticationLogin.Core.Domain.Applications.Interfaces;
using AuthenticationLogin.Infraestructure.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLogin.Infraestructure.Utils
{
    public static class DepencyRegisterExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddHttpClient();
            services.AddScoped<IProfileRegistrationService, ProfileRegistrationService>();
            services.AddScoped<IUserDataRetrieverService, UserDataRetrieverService>();
            services.AddScoped<IUserLogginService, UserLogginService>();
            //services.AddScoped<>();

            return services;
        }

    }
}
