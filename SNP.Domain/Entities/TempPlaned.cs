using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class TempPlaned
{
    public int CaseId { get; set; }

    public string? PlanedText { get; set; }
}
