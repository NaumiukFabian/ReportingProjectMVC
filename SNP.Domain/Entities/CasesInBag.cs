﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class CasesInBag
{
    public int Id { get; set; }

    public int? CaseId { get; set; }

    public int? BagsTypeId { get; set; }

    public virtual BagsType? BagsType { get; set; }

    public virtual Case? Case { get; set; }
}
