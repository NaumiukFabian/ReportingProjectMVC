using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class FilesOfEmail
{
    public int Id { get; set; }

    public int? FilesId { get; set; }

    public int? EmailId { get; set; }

    public virtual Email? Email { get; set; }

    public virtual File? Files { get; set; }
}
