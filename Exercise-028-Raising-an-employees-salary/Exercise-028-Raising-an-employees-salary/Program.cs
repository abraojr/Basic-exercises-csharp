using System;
using System.Globalization;

namespace Exercise_028_Raising_an_employees_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read an employee's data (name, gross salary and tax). Then, show the employee data (name and net salary).
             * Then, increase the employee's salary based on a given percentage (only the gross salary is affected by the percentage) and
             * show the employee's data again.*/

            Employee x;
            x = new Employee();

            Console.Write("Name: ");
            x.Name = Console.ReadLine();
            Console.Write("Gross salary : U$ ");
            x.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: U$ ");
            x.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Employee: " + x);
            Console.WriteLine();

            Console.Write("Enter the percentage to raise the salary: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.RaiseSalary(percentage);

            Console.WriteLine();
            Console.WriteLine("Updated data: " + x);
        }
    }
}
