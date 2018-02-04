//Define a class Student, which holds the following information about students: name, list of grades and average
//grade(calculated property, read-only). A single grade will be in range[2…6], e.g. 3.25 or 5.50.
//Read a list of students and print the students that have average grade ≥ 5.00 ordered by name(ascending), then by
// average grade(descending). Print the student name and the calculated average grade.

namespace _04._Average_Grades
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double Average => Grades.Average();

    }

    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //number of students

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                string[] inputArguments = Console.ReadLine().Split(); //take student details

                student.Name = inputArguments[0];
                student.Grades = inputArguments.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }

            students
                .Where(s => s.Average >= 5.00) //filter students with grades equal or above 5.00
                .OrderBy(s => s.Name) //order students by name
                .ThenByDescending(s => s.Average) //then by avarage grade
                .ToList() //make it a list in order to use the list.foreach function
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.Average:F2}")); //print the name and the average grade.


        }
    }
}
