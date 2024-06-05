using System;

public struct Student
{
    public int studentId;
    public string studentName;
    public string courseName;
    public DateTime dateOfBirth;
}

public class StudentManager
{
    public static void Main(string[] args)
    {
        int numStudents = 3;
        Student[] students = new Student[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nEnter information for student {0}:", i + 1);

            Console.Write("Student Id: ");
            students[i].studentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name: ");
            students[i].studentName = Console.ReadLine();

            Console.Write("Course Name: ");
            students[i].courseName = Console.ReadLine();

            // Get date of birth with error handling
            while (true)
            {
                Console.Write("Date of Birth (YYYY-MM-DD): ");
                string dobString = Console.ReadLine();
                try
                {
                    students[i].dateOfBirth = DateTime.Parse(dobString);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid date format. Please enter in YYYY-MM-DD format.");
                }
            }
        }

        Console.WriteLine("\nStudent Information:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            Console.WriteLine($"  Student Id: {students[i].studentId}");
            Console.WriteLine($"  Student Name: {students[i].studentName}");
            Console.WriteLine($"  Course Name: {students[i].courseName}");
            Console.WriteLine($"  Date of Birth: {students[i].dateOfBirth.ToString("yyyy-MM-dd")}");
        }
    }
}
