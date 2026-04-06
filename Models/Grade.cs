using System;
using System.Collections.Generic;

namespace UniSystem.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public DateTime EntryDate { get; set; }

    public string StudentId { get; set; } = null!;

    public int TeacherId { get; set; }

    public int SubjectId { get; set; }

    public decimal GradeValue { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
