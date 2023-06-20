using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Application.Installment.Queries.GetInstallmentForToday
{
    public class GetInstallmentForTodayQuery : IRequest<IEnumerable<InstallmentDto>>
    {
        public DateTime? DateToShow { get; set; }
    }
}
