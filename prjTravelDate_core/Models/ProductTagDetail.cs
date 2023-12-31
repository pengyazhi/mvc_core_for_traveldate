﻿using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class ProductTagDetail
{
    public int ProductTagDetailsId { get; set; }

    public int? ProductCategoryId { get; set; }

    public string? ProductTagDetailsName { get; set; }

    public virtual ProductCategory? ProductCategory { get; set; }

    public virtual ICollection<ProductTagList> ProductTagLists { get; set; } = new List<ProductTagList>();
}
