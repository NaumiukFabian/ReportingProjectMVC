using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SNP.Domain.Interfaces;
using SNP.Infrastructure.Persistence;
using SNP.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NewB2cContext>(options => options.UseSqlServer(
                    configuration.GetConnectionString("connstring")));

            services.AddScoped<IInstallmentRepository, InstallmentRepository>();
        }
    }
}
