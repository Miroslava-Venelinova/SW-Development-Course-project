using System;
using System.Collections.Generic;

namespace UniSystem.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
