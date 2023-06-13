﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Projectpoland
{
    public string? Signatures { get; set; }

    public string? Sha1 { get; set; }

    public int? Kwota { get; set; }

    public string? Zip { get; set; }

    public string? Name { get; set; }

    public string? Pesel { get; set; }

    public string? Expr1 { get; set; }

    public int? StateId { get; set; }

    public string? District { get; set; }
}
