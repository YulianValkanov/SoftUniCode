using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountOfStudent = int.Parse(Console.ReadLine());

            int CountOfLectures = int.Parse(Console.ReadLine());

            int InitialBonus = int.Parse(Console.ReadLine());

            int[] attedances = new int[CountOfStudent];

            for (int i = 0; i < CountOfStudent; i++)
            {
                attedances[i] = int.Parse(Console.ReadLine());
            }

            List<double> totalBonus = new List<double>(CountOfStudent);

            for (int j = 0; j < attedances.Length; j++)
            {              
               totalBonus.Add(1.0*attedances[j]/CountOfLectures*(5+InitialBonus));
            }



            Console.WriteLine($"Max Bonus: {Math.Ceiling( totalBonus.Max() )}. ");

            

            int index = totalBonus.IndexOf(totalBonus.Max());


            Console.WriteLine($"The student has attended {attedances[index]} lectures.");
        }
    }
}
