using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> student = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                List<string> array = Console.ReadLine().Split(" ").ToList();
                string first = array[0];
                string second = array[1];
                double grade = double.Parse(array[2]);

                Student studenti = new Student(first,second,grade);
                student.Add(studenti);
            }

           student= student.OrderByDescending(a => a.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,student)) ;
        }

        class Student
        {
            public Student (string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
