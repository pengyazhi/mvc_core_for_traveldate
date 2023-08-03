﻿using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class Coupon
{
    public int CouponId { get; set; }

    public int MemberId { get; set; }

    public int CouponListId { get; set; }

    public virtual CouponList CouponList { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
