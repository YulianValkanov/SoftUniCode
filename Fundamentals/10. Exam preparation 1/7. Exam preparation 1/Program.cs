using System;
using System.Linq;

namespace _7._Exam_preparation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string Index = Console.ReadLine();

            int Count = 0;

            while (Index!="End")
            {
                int CurrentIndex = int.Parse(Index);
              
                if (CurrentIndex>=0&&CurrentIndex<numbers.Length)
                {
                    Count++;

                    int CurrentValue = numbers[CurrentIndex];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i]<=CurrentValue&&numbers[i]!=-1)
                        {
                            numbers[i] += CurrentValue;
                        }
                        else if (numbers[i]>CurrentValue)
                        {
                            numbers[i] -= CurrentValue;
                        }
                     
                    }

                    numbers[CurrentIndex] = -1;
                }

                



                Index = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {Count} -> "+ String.Join(" ",numbers));
            
            
        }
    }
}
