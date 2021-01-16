using System;

namespace _5._SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int Start = int.Parse(Console.ReadLine());
            int End = int.Parse(Console.ReadLine());

            for (int i = Start; i <= End; i++)
            {
                char y = Convert.ToChar(i);
                Console.Write(y+" ");
            }

        }
    }
}
