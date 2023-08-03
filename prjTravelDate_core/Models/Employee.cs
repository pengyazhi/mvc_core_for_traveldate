using System;
using System.Collections.Generic;

namespace prjTravelDate_core.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public int? EmployeeLevel { get; set; }

    public string? EmployeeAccount { get; set; }

    public string? EmployeePassword { get; set; }
}
