using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {

            int FaildThreshold = int.Parse(Console.ReadLine());
            int FeiledTimes = 0;
            int CountGood = 0;
           double Sum = 0;
            string lastExemple = "";
            bool isFeld = false;

            while (FeiledTimes<FaildThreshold)
            {
                String ProblemName = Console.ReadLine();
                if ("Enough"==ProblemName)
                {
                    isFeld = true;
                    break;
                }
            
                int NewValue = int.Parse(Console.ReadLine());
                                       
                if(NewValue<=4)
                {
                    FeiledTimes++;                   
                }
                Sum += NewValue;
                CountGood++;
                lastExemple = ProblemName;

              
            }
            double Avarage = Sum/CountGood;

            if (isFeld == true)
            {
                Console.WriteLine($"Average score: {Avarage:f2}");
                Console.WriteLine($"Number of problems: {CountGood}");
                Console.WriteLine($"Last problem: {lastExemple}");
            }
            else
            {
                Console.WriteLine($"You need a break, {FeiledTimes} poor grades.");
            }


        }
            
                
        }
    }

