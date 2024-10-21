using System;
using System.Collections.Generic;

namespace StudentsPortal.Models;

public partial class LoginCredential
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Role { get; set; } = null!;

    public int? StudentId { get; set; }

    public int? InstructorId { get; set; }

    public virtual Instructor? Instructor { get; set; }

    public virtual Student? Student { get; set; }
}
