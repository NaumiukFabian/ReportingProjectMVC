﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Encryption
{
    public int Id { get; set; }

    public int? EncrytipnApId { get; set; }

    public string? Password { get; set; }

    public int? ClientId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual EncryptionApplication? EncrytipnAp { get; set; }
}
