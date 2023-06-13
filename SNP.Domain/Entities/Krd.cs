﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Krd
{
    public int Id { get; set; }

    public int? CaseId { get; set; }

    public int? State { get; set; }

    public DateTime? DateAdd { get; set; }

    public DateTime? DateDel { get; set; }

    public string? KrdId { get; set; }

    public string? KrdGuid { get; set; }

    public string? Description { get; set; }

    public DateTime? SendDocumentDate { get; set; }

    public bool? IsFromOldKrd { get; set; }

    public string? Krdlogin { get; set; }

    public virtual Case? Case { get; set; }
}
