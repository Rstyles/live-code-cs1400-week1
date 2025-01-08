using System;
using System.Data.Common;

namespace LinqDemo;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Grade { get; set; }

    public Student(int id, string name, double grade)
    {
        Id = id;
        Name = name;
        Grade = grade;
    }
}
