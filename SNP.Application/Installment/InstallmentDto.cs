using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Application.Installment
{
    public class InstallmentDto
    {
        public string? Date { get; set; }
        public decimal? Ammount { get; set; }
        public string Signature { get; set; } = default!;
        public string User { get; set; } = default!;
    }
}
