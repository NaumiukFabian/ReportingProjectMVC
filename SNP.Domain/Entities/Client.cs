﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class Client
{
    public int Id { get; set; }

    public string? Nip { get; set; }

    public string? Name { get; set; }

    public string? FullName { get; set; }

    public int? AddressId { get; set; }

    public string? Note { get; set; }

    public string? Regon { get; set; }

    public DateTime? NextTimeToDo { get; set; }

    public int? RekCount { get; set; }

    public string? BankAccountNr { get; set; }

    public int? ToDoEventsId { get; set; }

    public string? ContactNumber { get; set; }

    public string? NazwaKontaDoWplaty { get; set; }

    public int? RejestrType { get; set; }

    public string? RejestrName { get; set; }

    public string? RejestrProwadzacy { get; set; }

    public string? ZipName { get; set; }

    public string? Region { get; set; }

    public string? ReturnBankAccountNr { get; set; }

    public string? ReturnBankOwner { get; set; }

    public int? ClientType { get; set; }

    public string? Krs { get; set; }

    public string? Siedziba { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    public virtual ICollection<ContatsOfClient> ContatsOfClients { get; set; } = new List<ContatsOfClient>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Encryption> Encryptions { get; set; } = new List<Encryption>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<FilesOfClient> FilesOfClients { get; set; } = new List<FilesOfClient>();

    public virtual Event? ToDoEvents { get; set; }
}
