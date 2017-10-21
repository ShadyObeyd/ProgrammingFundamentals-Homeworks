using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrade
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public Student (string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }
    }
    class AverageGrade
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0];
                List<double> grades = new List<double>();

                for (int j = 1; j < inputTokens.Length; j++)
                {
                    double currentGrade = double.Parse(inputTokens[j]);
                    grades.Add(currentGrade);
                }

                Student student = new Student(name, grades);

                students.Add(student);
            }

            students = students
                .Where(s => s.Grades.Average() >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Grades.Average())
                .ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.Grades.Average():f2}");
            }
        }
    }
}
