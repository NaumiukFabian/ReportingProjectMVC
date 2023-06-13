﻿using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class CasesOfListOfCase
{
    public int Id { get; set; }

    public int? CaseId { get; set; }

    public int? ListOfCasesId { get; set; }

    public virtual Case? Case { get; set; }

    public virtual CustomListOfCase? ListOfCases { get; set; }
}
