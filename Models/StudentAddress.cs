using System;
using System.Collections.Generic;

namespace StudentsPortal.Models;

public partial class StudentAddress
{
    public int AddressId { get; set; }

    public int StudentId { get; set; }

    public string? AddressType { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public virtual Student Student { get; set; } = null!;
}
