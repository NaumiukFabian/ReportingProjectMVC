﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Invoice
{
    public int Id { get; set; }

    public string? Nr { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public int? ContratId { get; set; }

    public int? EventId { get; set; }

    public virtual Contract? Contrat { get; set; }

    public virtual ICollection<EventsForInvoice> EventsForInvoices { get; set; } = new List<EventsForInvoice>();

    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
}
