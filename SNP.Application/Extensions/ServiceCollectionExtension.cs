using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SNP.Application.ApplicationUser;
using SNP.Application.Installment.Queries.GetInstallmentForToday;
using SNP.Application.Mapping;
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
            services.AddMediatR(typeof(GetInstallmentForTodayQueryHandler));
            services.AddAutoMapper(typeof(InstallmentMappingProfile));
            services.AddScoped<IUserContext, UserContext>();
        }
    }
}
