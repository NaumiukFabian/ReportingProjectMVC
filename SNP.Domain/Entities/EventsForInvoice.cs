﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class EventsForInvoice
{
    public int Id { get; set; }

    public int? InvoiceId { get; set; }

    public int? EventId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
