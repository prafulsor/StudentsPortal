using System;
using System.Collections.Generic;

namespace StudentsPortal.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string? DepartmentHead { get; set; }
}
