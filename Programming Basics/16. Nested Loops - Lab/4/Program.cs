using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
           int count = 0;
            bool isFoub = false;

            for (int n1 = first; n1 <= end; n1++)
            {
                
                for (int n2 = first; n2 <= end; n2++)
                {
                    count++;
                    if (n1+n2==magic)
                    {                       
                        Console.WriteLine($"Combination N:{count} ({ n1} + {n2} = {magic})");
                        isFoub = true;
                        break;                 
                    }
                   
                }
                if (isFoub)
                {
                    break;
                }
            }
            if (isFoub==false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }


        }
    }
}
