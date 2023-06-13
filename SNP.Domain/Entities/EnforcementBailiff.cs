using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class EnforcementBailiff
{
    public int Id { get; set; }

    public int? CaseId { get; set; }

    public string? EnforcmentSignature { get; set; }

    public decimal? Kze { get; set; }

    public virtual Case? Case { get; set; }
}
