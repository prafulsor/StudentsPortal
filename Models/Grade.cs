using System;
using System.Collections.Generic;

namespace StudentsPortal.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public int EnrollmentId { get; set; }

    public decimal? GradeValue { get; set; }

    public DateOnly? GradeDate { get; set; }

    public virtual Enrollment Enrollment { get; set; } = null!;
}
