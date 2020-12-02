using System;
using System.Globalization;

namespace Exercise_026_Class_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the name and salary of two employees. Then, show the average salary of employees.*/

            Employee f1, f2;
            f1 = new Employee();
            f2 = new Employee();

            Console.WriteLine("First employee's data: ");
            Console.Write("Name: ");
            f1.Name = Console.ReadLine();
            Console.Write("Salary: U$ ");
            f1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Second employee's data: ");
            Console.Write("Name: ");
            f2.Name = Console.ReadLine();
            Console.Write("Salary: U$ ");
            f2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avgSalary = (f1.Salary + f2.Salary) / 2;
            Console.WriteLine("Average salary = U$ " + avgSalary.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
