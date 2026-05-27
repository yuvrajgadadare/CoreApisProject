using System;
using System.Collections.Generic;

namespace CoreApisProject.Models;

public partial class Student
{
    public int Rno { get; set; }

    public string? Name { get; set; }

    public string? Qualification { get; set; }

    public double? Percentage { get; set; }
}
