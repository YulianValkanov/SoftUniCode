using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Enegry = int.Parse(Console.ReadLine());

            int count = 0;

            string ImputSteps = Console.ReadLine();

            bool isWiner = true;

           

            while (ImputSteps != "End of battle")
            {
                int Steps = int.Parse(ImputSteps);

                if (Enegry<Steps)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {Enegry} energy");
                    isWiner = false;
                    break;
                }
                else
                {
                    
                    Enegry -= Steps;

                    count++;
                    
                }
                if (count % 3 == 0)
                {
                    Enegry += count;
                }

                ImputSteps = Console.ReadLine();

            }

            if (isWiner)
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {Enegry}");
            }
        }
    }
}
