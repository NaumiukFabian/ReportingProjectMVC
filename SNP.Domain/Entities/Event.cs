using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Event
{
    public int Id { get; set; }

    public string? Header { get; set; }

    public string? Text { get; set; }

    public DateTime? Time { get; set; }

    public int? Direction { get; set; }

    public bool? Planed { get; set; }

    public int? UserId { get; set; }

    public int? PersonId { get; set; }

    public int? CaseId { get; set; }

    public int? TypeId { get; set; }

    public int? ClientId { get; set; }

    public int? LastAsset { get; set; }

    public virtual ICollection<AssetEvent> AssetEvents { get; set; } = new List<AssetEvent>();

    public virtual Case? Case { get; set; }

    public virtual ICollection<Case> Cases { get; set; } = new List<Case>();

    public virtual Client? Client { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();

    public virtual EpuDecision? EpuDecision { get; set; }

    public virtual ICollection<EventsForInvoice> EventsForInvoices { get; set; } = new List<EventsForInvoice>();

    public virtual ICollection<EventsOfAgrement> EventsOfAgrements { get; set; } = new List<EventsOfAgrement>();

    public virtual ICollection<FilesOfEent> FilesOfEents { get; set; } = new List<FilesOfEent>();

    public virtual AssetEvent? LastAssetNavigation { get; set; }

    public virtual Payment? Payment { get; set; }

    public virtual RequestsCase? RequestsCase { get; set; }

    public virtual Sm? Sm { get; set; }
}
