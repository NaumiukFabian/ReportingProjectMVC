using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class CustomListOfCase
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CasesOfListOfCase> CasesOfListOfCases { get; set; } = new List<CasesOfListOfCase>();
}
