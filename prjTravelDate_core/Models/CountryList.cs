using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class CountryList
{
    public int CountryId { get; set; }

    public string? Country { get; set; }

    public virtual ICollection<CityList> CityLists { get; set; } = new List<CityList>();
}
