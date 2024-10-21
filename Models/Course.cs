using System;
using System.Collections.Generic;

namespace StudentsPortal.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public string CourseCode { get; set; } = null!;

    public string? Description { get; set; }

    public int Credits { get; set; }

    public string? Department { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<ClassAssignment> ClassAssignments { get; set; } = new List<ClassAssignment>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
