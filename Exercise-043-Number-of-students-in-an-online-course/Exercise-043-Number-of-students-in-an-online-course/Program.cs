using Exercise_043_Number_of_students_in_an_online_course.Entities;
using System;
using System.Collections.Generic;

namespace Exercise_043_Number_of_students_in_an_online_course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*In an online course portal, each user has a unique code, represented by an integer.
             *Each instructor of the portal can have several courses, and the same student can enroll in as many courses as he/she wants. Thus, the total 
             *number of students of an instructor is not simply the sum of the students of all the courses that he has, because there can be repeated 
             *students in more than one course.
             *Instructor Alex has three courses A, B and C, and wants to know his total number of students.
             *The program should read students from Instructor Alex's A, B and C courses, then show the total amount and students of it*/

            HashSet<Student> set = new HashSet<Student>();
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Student(id));
            }
            Console.Write("How many students for course B? ");
            int j = int.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Student(id));
            }
            Console.Write("How many students for course C? ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Student(id));
            }

            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
