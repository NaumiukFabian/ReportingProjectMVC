using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Odsetki
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Value { get; set; }
}
