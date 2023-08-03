using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class Favorite
{
    public int FavoriteId { get; set; }

    public int MemberId { get; set; }

    public int? ProductId { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual ProductList? Product { get; set; }
}
