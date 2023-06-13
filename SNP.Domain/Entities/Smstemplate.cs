using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Smstemplate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Text { get; set; }

    public bool? IsAnkieta { get; set; }
}
