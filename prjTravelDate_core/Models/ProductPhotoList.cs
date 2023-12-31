﻿using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class ProductPhotoList
{
    public int ProductPhotoListId { get; set; }

    public int? ProductId { get; set; }

    public byte[]? Photo { get; set; }

    public bool? OnSlide { get; set; }

    public string? ImagePath { get; set; }

    public virtual ProductList? Product { get; set; }

    public virtual ICollection<TripDetail> TripDetails { get; set; } = new List<TripDetail>();
}
