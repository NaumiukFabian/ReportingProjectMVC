using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Company
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Nip { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
