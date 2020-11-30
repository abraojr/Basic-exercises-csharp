using System;
using System.Globalization;

namespace Exercise_004_The_employees_number_and_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program that reads the number of an employee, his number of hours worked, the amount he receives for 
                 * hour and calculate that employee's salary. Then show the employee's number and salary, to two decimal places.*/

            int empNumber, hrWorked;
            double salaryHr, totSalary;

            Console.Write("Employee Number:");
            empNumber = int.Parse(Console.ReadLine());

            Console.Write("Worked hours:");
            hrWorked = int.Parse(Console.ReadLine());

            Console.Write("Hourly wage:");
            salaryHr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totSalary = hrWorked * salaryHr;

            Console.WriteLine("NUMBER: " + empNumber);
            Console.WriteLine("SALARY: U$ " + totSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
