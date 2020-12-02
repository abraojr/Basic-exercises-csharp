using System;
using System.Globalization;

namespace Exercise_029_Students_grades
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read a student's name and the three grades he obtained in the three quarters of the year 
             *(first quarter is worth 30 and the second and third are worth 35 each). At the end, show the student's final grade in the year.
             *Also say whether the student was APROVED or REPROVED and, if its reproved, how many points are left for the student to obtain
             *the minimum to pass (which is 60 points).*/

            Student x;
            x = new Student();

            Console.Write("Student's name: ");
            x.Name = Console.ReadLine();
            Console.WriteLine("Enter the student's three grades: ");
            x.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double finalGrade = x.FinalGrade();

            Console.WriteLine("FINAL GRADE : " + x);

            if (x.Aproved())
            {
                Console.WriteLine("APROVED");
            }
            else
            {
                Console.WriteLine("REPROVED");
                Console.WriteLine("LACKED: " + x.RemainingGrade().ToString("F2", CultureInfo.InvariantCulture) + " POINTS");
            }

        }
    }
}
