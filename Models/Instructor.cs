using System;
using System.Collections.Generic;

namespace StudentsPortal.Models;

public partial class Instructor
{
    public int InstructorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Department { get; set; } = null!;

    public virtual ICollection<ClassAssignment> ClassAssignments { get; set; } = new List<ClassAssignment>();

    public virtual ICollection<LoginCredential> LoginCredentials { get; set; } = new List<LoginCredential>();
}
