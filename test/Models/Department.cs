using System;
using System.Collections.Generic;

namespace test.Models;

public partial class Department
{
    public int Id { get; set; }

    public string? DepartmentName { get; set; }

    public int? NumberOfEmployees { get; set; }
}
