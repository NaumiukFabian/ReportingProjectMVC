using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Application.Installment.Queries.GetInstallmentForTodayByName
{
    public class GetInstallmentForTodayByNameQuery : IRequest<IEnumerable<InstallmentDto>>
    {
        public string UserName { get; set; } = default!;
    }
}
