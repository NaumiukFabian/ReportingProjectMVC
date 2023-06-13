﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class DictStateOfCommitment
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Case> Cases { get; set; } = new List<Case>();
}
