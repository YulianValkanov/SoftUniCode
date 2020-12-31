using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int Salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string TabName = Console.ReadLine();

                switch (TabName)
                {
                    case "Facebook":
                        Salary -= 150;
                        break;
                        
                    case "Instagram":
                        Salary -= 100;
                        break;
                        
                    case "Reddit":
                        Salary -= 50;
                        break;
                }
                if (Salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                }

            }
            if (Salary>0)
            {
                Console.WriteLine(Salary);
            }
            
            
        }
    }
}
