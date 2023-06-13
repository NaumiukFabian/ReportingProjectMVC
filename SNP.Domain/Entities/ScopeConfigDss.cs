using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class ScopeConfigDss
{
    public Guid ConfigId { get; set; }

    public string ConfigData { get; set; } = null!;

    public string? ScopeStatus { get; set; }
}
