using System;

namespace _03.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string employeeName = Console.ReadLine();
            int employeeAge = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            double employeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {employeeName}");
            Console.WriteLine($"Age: {employeeAge}");
            Console.WriteLine($"Employee ID: {employeeID:d8}");
            Console.WriteLine($"Salary: {employeeSalary:f2}");
        }
    }
}
