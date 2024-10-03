using System;
using System.Data.Entity;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            // Add a new student
            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(2000, 1, 1)
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }
        using (var context = new SchoolContext())
        {
            var students = context.Students.ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}, Date of Birth: {student.DateOfBirth}");
            }
        }
    }
}
