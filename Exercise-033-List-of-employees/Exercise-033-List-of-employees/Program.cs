using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise_033_List_of_employees
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Make a program to read an integer number  N and then the data (id, name and salary) of N employees. There should be no id repetition.
             *Then, make the increase of X per cent in the salary of a particular employee. To do this, the program must read an id and the value 
             *X.If the id informed does not exist,  do show a message and  do abort the operation. At the end, show the updated list of employees.
             *Remember to apply the encapsulation technique so that the salary cannot be freely changed. A salary can only be increased on the 
             *basis of a given percentage increase operation.*/

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase : ");
            int _inId = int.Parse(Console.ReadLine());

            Employee func = list.Find(x => x.Id == _inId);
            if (func != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.increaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This Id does not exist!!");
                Console.WriteLine();
            }
            Console.WriteLine("Updated list of employees:");
            Console.WriteLine();
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
