using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            int Number = int.Parse(Console.ReadLine());
         

            for (int d1 = 1; d1 <= 9; d1++)
            {
                if(Number%d1!=0)
                {
                    continue;
                }

                for (int d2 = 1; d2 <= 9; d2++)
                {
                    if(Number % d2 != 0)
                     {
                        continue;
                    }
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        if (Number % d3 != 0)
                        {
                            continue;
                        }
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            if (Number % d4 != 0)
                            {
                                continue;
                            }
                            Console.Write($"{d1}{d2}{d3}{d4} ");
                        }
                    }
                }
            }
            
        }
    }
}
