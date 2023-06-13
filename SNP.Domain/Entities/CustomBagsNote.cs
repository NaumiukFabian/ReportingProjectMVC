using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class CustomBagsNote
{
    public int Id { get; set; }

    public int? BagsId { get; set; }

    public int? DefaultNotesId { get; set; }

    public virtual BagsType? Bags { get; set; }

    public virtual DictDefaultNote? DefaultNotes { get; set; }
}
