using System;
using System.Collections.Generic;

namespace Employee_Management_System.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public int Salary { get; set; }

    public string Position { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public Employee(int empId, string name, int age, int salary, string position, string country, string gender)
    {
        EmpId = empId;
        Name = name;
        Age = age;
        Salary = salary;
        Position = position;
        Country = country;
        Gender = gender;
    }
    public Employee()
    {

    }
}
