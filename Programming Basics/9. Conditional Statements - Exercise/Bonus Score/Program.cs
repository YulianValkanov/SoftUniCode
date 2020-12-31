using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num = int.Parse(Console.ReadLine());

            Double bonus = 0.00;

            if (Num<100)
            {
                bonus = 5;
            }
            else if (Num>1000)
            {
                bonus = Num * 0.1;
            }
            else
            {
                bonus= Num * 0.2; 
            }

            if (Num%2==0)
            {
                bonus = bonus + 1;
            }
            else if (Num%10==5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);

            Console.WriteLine(Num+bonus);
        }
    }
}
