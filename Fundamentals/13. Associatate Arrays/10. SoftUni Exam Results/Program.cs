using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();

            Dictionary<string, int> student = new Dictionary<string, int>();

            Dictionary<string, int> submitions = new Dictionary<string, int>();


            while (imput!= "exam finished")
            {
                string[] cmdArgs = imput.Split("-");
                string user = cmdArgs[0];
                if (cmdArgs.Length>2)
                {
                    string langueges = cmdArgs[1];
                    int points = int.Parse( cmdArgs[2]);

                    if (!student.ContainsKey(user))
                    {
                        student.Add(user, points);
                    }
                    else
                    {
                        if (student[user] <points)
                        {
                            student[user] = points;
                        }
                    }

                    if (!submitions.ContainsKey(langueges))
                    {
                        submitions.Add(langueges,0);
                    }
                    submitions[langueges]++;
                }
                else
                {
                    student.Remove(user);
                }
                imput = Console.ReadLine();

            }
            Console.WriteLine("Results:");

            foreach (var currentStudent in student.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{currentStudent.Key} | {currentStudent.Value} ");
            }
            Console.WriteLine("Submissions:");

            foreach (var currentSubmitions in submitions.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{currentSubmitions.Key} - {currentSubmitions.Value}");
            }

        }
    }
}
