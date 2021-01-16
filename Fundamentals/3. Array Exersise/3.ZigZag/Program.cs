using System;
using System.Linq;

namespace _3.ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] FirstAray = new string[n];

            string[] SecondAray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] CurrentArray = Console.ReadLine().Split(" ").ToArray();

                string IndexZeroElement = CurrentArray[0];
                string IndexOneElement = CurrentArray[1];

                if (i%2==0)
                {
                    FirstAray[i] = IndexZeroElement;
                    SecondAray[i] = IndexOneElement;
                }
                else if (i%2==1)
                {
                    FirstAray[i] = IndexOneElement;
                    SecondAray[i] = IndexZeroElement;
                }


                
            }
            Console.WriteLine(string.Join(" ", FirstAray));
            Console.WriteLine(string.Join(" ", SecondAray));
        }
    }
}
