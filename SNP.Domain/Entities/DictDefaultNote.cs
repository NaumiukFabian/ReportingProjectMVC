using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class DictDefaultNote
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CustomBagsNote> CustomBagsNotes { get; set; } = new List<CustomBagsNote>();
}
