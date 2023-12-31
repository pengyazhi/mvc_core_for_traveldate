﻿using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class ScheduleList
{
    public int ScheduleId { get; set; }

    public int? ForumListId { get; set; }

    public int? TripId { get; set; }

    public virtual ForumList? ForumList { get; set; }

    public virtual Trip? Trip { get; set; }
}
