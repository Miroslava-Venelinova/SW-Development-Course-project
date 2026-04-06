using System;
using System.Collections.Generic;

namespace UniSystem.Models;

public partial class TeachersSubject
{
    public int Teacher { get; set; }

    public int Subject { get; set; }

    public virtual Subject SubjectNavigation { get; set; } = null!;

    public virtual Teacher TeacherNavigation { get; set; } = null!;
}
