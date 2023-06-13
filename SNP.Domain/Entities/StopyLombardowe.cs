using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class StopyLombardowe
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Value { get; set; }
}
