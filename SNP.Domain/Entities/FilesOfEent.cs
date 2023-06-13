﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class FilesOfEent
{
    public int Id { get; set; }

    public int? FileId { get; set; }

    public int? EventId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual File? File { get; set; }
}
