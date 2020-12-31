using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Prosti = 0;
            int Slojni = 0;

            while (true)
            {
                string Number = Console.ReadLine();
                if(Number=="stop")
                {
                    break;
                }
                else
                {
                    int Num1 = int.Parse(Number);
                    if(Num1<0)
                    {
                        Console.WriteLine("Number is negative.");
                    }
                    else
                    {
                        if ((Num1 % 2 == 0 || Num1 % 3 == 0) && Num1 > 3)
                        {
                            Slojni += Num1;
                        }
                        else
                        {
                            Prosti += Num1;
                        }
                    }
                    
                }
                
            }


            Console.WriteLine($"Sum of all prime numbers is: {Prosti}");
            Console.WriteLine($"Sum of all non prime numbers is: {Slojni}");
        }
    }
}
