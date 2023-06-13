using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Person
{
    public int Id { get; set; }

    public string? Sha1 { get; set; }

    public bool? IsReturned { get; set; }

    public int? PastPersonId { get; set; }

    public int? Type { get; set; }

    public DateTime? NextDate { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Case> Cases { get; set; } = new List<Case>();

    public virtual ContactsDetail? ContactsDetail { get; set; }

    public virtual ContatsOfClient? ContatsOfClient { get; set; }

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();

    public virtual ICollection<EmailsAddress> EmailsAddresses { get; set; } = new List<EmailsAddress>();

    public virtual ICollection<Person> InversePastPerson { get; set; } = new List<Person>();

    public virtual Person? PastPerson { get; set; }

    public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
}
