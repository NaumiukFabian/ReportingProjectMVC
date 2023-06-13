using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Wplaty
{
    public decimal? Amount { get; set; }

    public DateTime? Date { get; set; }
}
