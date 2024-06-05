using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public string Grade { get; set; }
    public string Program { get; set; }
}

public class LinqExample
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Alice", Grade = "A", Program = "BCA" },
            new Student { Name = "Bob", Grade = "B", Program = "BCOM" },
            new Student { Name = "Antony", Grade = "A", Program = "BCA" },
            new Student { Name = "Nikesh", Grade = "B+", Program = "BCA" },
        };

        var filteredStudents = students.Where(student => student.Grade == "A" && student.Program == "BCA");

        if (filteredStudents.Any())
        {
            Console.WriteLine("Students with grade 'A' and program 'BCA':");
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }
        else
        {
            Console.WriteLine("No students found with grade 'A' and program 'BCA'.");
        }
    }
}
