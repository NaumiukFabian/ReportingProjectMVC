using Microsoft.Extensions.DependencyInjection;
using SNP.Application.Mapping;
using SNP.Application.Services;
using SNP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IInstallmentService, InstallmentService>();
            services.AddAutoMapper(typeof(InstallmentMappingProfile));
        }
    }
}
