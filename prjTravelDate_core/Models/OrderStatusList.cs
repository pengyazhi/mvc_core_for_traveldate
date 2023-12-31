﻿using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class OrderStatusList
{
    public int StatusId { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
