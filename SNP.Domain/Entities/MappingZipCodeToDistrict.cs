using System;
using System.Collections.Generic;

namespace SNP.Domain.Entities;

public partial class MappingZipCodeToDistrict
{
    public string? ZipCode { get; set; }

    public string? District { get; set; }
}
