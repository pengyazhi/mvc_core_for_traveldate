﻿using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class PaymentList
{
    public int PaymentId { get; set; }

    public string? Payment { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
