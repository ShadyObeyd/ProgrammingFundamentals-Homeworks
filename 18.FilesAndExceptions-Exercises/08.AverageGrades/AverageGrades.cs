using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08.AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, List<double> grades, double averageGrade)
        {
            this.Name = name;
            this.Grades = grades;
            this.AverageGrade = averageGrade;
        }
    }

    class AverageGrades
    {
        static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt").Skip(1).ToArray();

            File.Delete("Output.txt");

            List<Student> students = new List<Student>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentStudent = input[i];

                string[] tokens = currentStudent.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                List<double> grades = tokens.Skip(1).Select(double.Parse).ToList();
                double averageGrade = grades.Average();

                Student student = new Student(name, grades, averageGrade);

                students.Add(student);
            }

            students =
                students
                .Where(g => g.AverageGrade >= 5)
                .OrderBy(n => n.Name)
                .ThenByDescending(g => g.AverageGrade)
                .ToList();

            foreach (Student student in students)
            {
                string result = $"{student.Name} -> {student.AverageGrade:f2}" + Environment.NewLine;

                File.AppendAllText("Output.txt", result);
            }
        }
    }
}
