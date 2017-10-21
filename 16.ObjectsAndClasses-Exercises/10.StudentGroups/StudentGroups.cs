using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _10.StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }

    class StudentGroups
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Town> towns = new List<Town>();

            int townCount = 0;

            ProcessInput(input, towns, ref townCount);

            List<Group> groups = new List<Group>();

            foreach (Town town in towns.OrderBy(t => t.Name))
            {
                string townName = town.Name;
                int seatCount = town.SeatCount;
                List<Student> students =
                    town.Students
                    .OrderBy(s => s.RegisterDate)
                    .ThenBy(s => s.Name)
                    .ThenBy(s => s.Email)
                    .ToList();

                while (students.Any())
                {
                    Group group = new Group();

                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatCount).ToList();

                    students = students.Skip(group.Town.SeatCount).ToList();

                    groups.Add(group);
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {townCount} towns:");

            foreach (Group group in groups)
            {
                string townName = group.Town.Name;
                List<Student> students = group.Students;
                List<string> emails = new List<string>();

                foreach (Student student in students)
                {
                    emails.Add(student.Email);
                }

                Console.WriteLine($"{townName} => {string.Join(", ", emails)}");
            }

        }

        private static void ProcessInput(string input, List<Town> towns, ref int townCount)
        {
            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    string[] tokens = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                    string[] seatTokens = tokens[1].Split(' ');

                    string townName = tokens[0];
                    int seatsCount = int.Parse(seatTokens[0]);

                    Town town = new Town();

                    town.Name = townName;
                    town.SeatCount = seatsCount;
                    town.Students = new List<Student>();

                    towns.Add(town);

                    townCount++;
                }
                else
                {
                    string[] tokens = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    string studentName = tokens[0].Trim();
                    string email = tokens[1].Trim();
                    DateTime registerDate = DateTime.ParseExact(tokens[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    Student student = new Student();

                    student.Name = studentName;
                    student.Email = email;
                    student.RegisterDate = registerDate;

                    towns.Last().Students.Add(student);
                }

                input = Console.ReadLine();
            }
        }
    }
}
