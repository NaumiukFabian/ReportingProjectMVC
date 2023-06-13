using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Address
{
    public int Id { get; set; }

    public string? Street { get; set; }

    public string? Number { get; set; }

    public string? Local { get; set; }

    public string? Zip { get; set; }

    public int? CityId { get; set; }

    public int? PersonId { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual Person? Person { get; set; }
}
