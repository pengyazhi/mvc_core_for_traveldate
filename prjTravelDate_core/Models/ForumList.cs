using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class ForumList
{
    public int ForumListId { get; set; }

    public int? MemberId { get; set; }

    public string? Title { get; set; }

    public DateTime? DueDate { get; set; }

    public byte[]? Content { get; set; }

    public DateTime? ReleaseDatetime { get; set; }

    public int? Likes { get; set; }

    public int? Watches { get; set; }

    public virtual Member? Member { get; set; }

    public virtual ICollection<ReplyList> ReplyLists { get; set; } = new List<ReplyList>();

    public virtual ICollection<ScheduleList> ScheduleLists { get; set; } = new List<ScheduleList>();
}
