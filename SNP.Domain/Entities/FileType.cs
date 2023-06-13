using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class FileType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? IconName { get; set; }

    public bool? IsEncrypted { get; set; }

    public virtual ICollection<File> Files { get; set; } = new List<File>();
}
