using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            string Text = Console.ReadLine();

            int Sum = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                char Letter = Text[i];           
                switch(Letter)
                {
                    case 'a':
                        Sum += 1;
                        break;
                    case 'e':
                        Sum += 2;
                        break;
                    case 'i':
                        Sum += 3;
                        break;
                    case 'o':
                        Sum += 4;
                        break;
                    case 'u':
                        Sum += 5;
                        break;
             
                }
                
            }
            Console.WriteLine(Sum);

        }
    }
}
