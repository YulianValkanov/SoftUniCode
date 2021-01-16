using System;

namespace _9._Spice
{
    class Program
    {
        static void Main(string[] args)
        {
            int Imput = int.Parse(Console.ReadLine());
            int Number = Imput;
            int Leving = 0;
            int Count = 0;

            while (true)
            {

                if (Number>=100)
                {
                    
                    Leving += Number - 26;
                    Number -= 10;
                    Count++;
                }

                        
            }
            Console.WriteLine(Leving);
            Console.WriteLine(Count);
        }
    }
}
