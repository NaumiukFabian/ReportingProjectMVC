using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Agreement
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Ammount { get; set; }

    public int? CaseId { get; set; }

    public virtual Case? Case { get; set; }

    public virtual ICollection<EventsOfAgrement> EventsOfAgrements { get; set; } = new List<EventsOfAgrement>();
}
