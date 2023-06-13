using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class EmailsAddress
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public int? PersonId { get; set; }

    public string? Description { get; set; }

    public virtual Person? Person { get; set; }
}
