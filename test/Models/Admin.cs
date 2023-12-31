﻿using System;
using System.Collections.Generic;

namespace test.Models;

public partial class Admin
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Patronymic { get; set; }

    public DateTime? DateOfAdmission { get; set; }

    public decimal? Salary { get; set; }

    public int? NumberOfDaysOnLeave { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
