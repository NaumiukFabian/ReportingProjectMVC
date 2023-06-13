﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Gapowicze
{
    public int Id { get; set; }

    public int? CaseId { get; set; }

    public int? State { get; set; }

    public DateTime? DateAdd { get; set; }

    public virtual Case? Case { get; set; }
}
