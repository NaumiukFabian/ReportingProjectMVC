﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Status
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Status1 { get; set; }
}
