using System;
using System.Collections.Generic;

namespace HighestGPA
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student> {
                new Student { Name = "Abby",    GPA = 4.22m },
                new Student { Name = "Bobby",   GPA = 2.98m },
                new Student { Name = "Cory",    GPA = 2.80m },
                new Student { Name = "Davey",   GPA = 4.42m },
                new Student { Name = "Eddy",    GPA = 4.15m },
                new Student { Name = "Fanny",   GPA = 3.73m },
                new Student { Name = "Georgie", GPA = 1.24m },
                new Student { Name = "Harry",   GPA = 3.59m },
                new Student { Name = "Izzy",    GPA = 2.38m },
                new Student { Name = "Jimmy",   GPA = 4.93m }
            };
            decimal maxGPA = 0m;
            string name = "";
            foreach (var Student in students){
                if (maxGPA < Student.GPA) {
                    maxGPA = Student.GPA;
                    name = Student.Name;
                }
            }
            Console.WriteLine($"The Student with the highest GPA is {name} and their GPA is {maxGPA}");
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public decimal GPA { get; set; }
    }
}
