using System;
using System.Collections.Generic;

namespace UniSystem.Models;

public partial class StudentsSubject
{
    public string Student { get; set; } = null!;

    public int Subject { get; set; }

    public virtual Student StudentNavigation { get; set; } = null!;

    public virtual Subject SubjectNavigation { get; set; } = null!;
}
