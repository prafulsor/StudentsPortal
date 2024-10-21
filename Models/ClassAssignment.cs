using System;
using System.Collections.Generic;

namespace StudentsPortal.Models;

public partial class ClassAssignment
{
    public int AssignmentId { get; set; }

    public int InstructorId { get; set; }

    public int CourseId { get; set; }

    public DateOnly? AssignmentDate { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Instructor Instructor { get; set; } = null!;
}
