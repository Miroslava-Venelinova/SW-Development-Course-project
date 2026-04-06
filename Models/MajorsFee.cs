using System;
using System.Collections.Generic;

namespace UniSystem.Models;

public partial class MajorsFee
{
    public int Major { get; set; }

    public decimal MajorFee { get; set; }

    public virtual Major MajorNavigation { get; set; } = null!;
}
