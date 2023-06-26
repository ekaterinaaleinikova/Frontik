using System;
using System.Collections.Generic;

namespace test.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Lastname { get; set; }

    public string? FatherName { get; set; }

    public DateTime? DateOfHire { get; set; }

    public decimal? Salary { get; set; }

    public int? NumberOfDaysOnLeave { get; set; }

    public int? DepartmentId { get; set; }

    public bool? IsCurrentlyEmployed { get; set; }

    public bool? CanGoOnVacation { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
