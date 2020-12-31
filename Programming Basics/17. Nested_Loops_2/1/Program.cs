using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());
            int First = 1;
            bool isStop = false;

            for (int row = 1; row <= Num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if(First>Num)
                    {
                        isStop = true;
                        break;
                    }
                    Console.Write(First + " ");
                    First++;
                }
                if(isStop)
                {
                    break;
                }
                Console.WriteLine();

            }



            
        }
    }
}
