﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class SystemLog
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Text { get; set; }

    public int? Type { get; set; }

    public virtual User? User { get; set; }
}
