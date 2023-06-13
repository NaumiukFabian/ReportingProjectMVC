using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class WplatyZleceniaPerWindykator
{
    public decimal? Amount { get; set; }

    public DateTime? Date { get; set; }

    public string? Name { get; set; }
}
