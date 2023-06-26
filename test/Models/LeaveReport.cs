using System;
using System.Collections.Generic;

namespace test.Models;

public partial class LeaveReport
{
    public int Id { get; set; }

    public string? Reason { get; set; }

    public DateTime? LeaveStartDate { get; set; }

    public DateTime? LeaveEndDate { get; set; }

    public int? EmployeeId { get; set; }

    public bool? IsLeaveApproved { get; set; }

    public int? AdminId { get; set; }
}
