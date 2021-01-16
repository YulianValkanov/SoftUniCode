using System;

namespace _2._2.__Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");

            var string1 = input[0];
            var string2 = input[1];

            int[] num1 = new int[string1.Length];
            int[] num2 = new int[string2.Length];

            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = (int)string1[i];
            }

            for (int i = 0; i < num2.Length; i++)
            {
                num2[i] = (int)string2[i];
            }

          
            int sum = 0;

            if (num1.Length==num2.Length)
            {
                for (int i = 0; i < num2.Length; i++)
                {
                    sum += num1[i] * num2[i];
                }
            }
            else if (num1.Length>num2.Length)
            {
                int num1Lengh = num1.Length;
                int num2Lengh = num2.Length;
                int different = num1Lengh - num2Lengh;

                for (int i = 0; i < num2.Length; i++)
                {
                    sum += num1[i] * num2[i];
                }
                

                for (int i = num2Lengh; i < num1Lengh; i++)
                {
                    sum += num1[i];
                }
            }
            else
            {

                int num1Lengh = num1.Length;
                int num2Lengh = num2.Length;
                int different = num2Lengh - num1Lengh;

                for (int i = 0; i < num1.Length; i++)
                {
                    sum += num1[i] * num2[i];
                }

                for (int i = num1Lengh; i < num2Lengh; i++)
                {
                    sum += num2[i];
                }

               
            }
            Console.WriteLine(sum);
        }
    }
}
