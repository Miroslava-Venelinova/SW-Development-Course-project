using System;
using System.Collections.Generic;

namespace UniSystem.Models;

public partial class Student
{
    public string FacultyNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int Address { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public int Major { get; set; }

    public string DegreeType { get; set; } = null!;

    public int Group { get; set; }

    public int Stream { get; set; }

    public decimal? AverageGrade { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public decimal? UnpaidFees { get; set; }

    public virtual Address AddressNavigation { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual Major MajorNavigation { get; set; } = null!;
}
