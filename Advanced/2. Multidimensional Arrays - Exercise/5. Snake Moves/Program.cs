using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string word = Console.ReadLine();

            int Row = input[0];
            int Col = input[1];

            string[,] matrix = new string[Row, Col];

            int Count = 0;
            int Index = 0;

            for (int row = 0; row < Row; row++)
            {
                      
                if (Count % 2 == 0)
                {
                    for (int col = 0; col < Col; col++)
                    {
                        string curWord = word[Index].ToString();
                        matrix[row, col] = curWord;

                        if (Index>=word.Length-1)
                        {
                            Index = 0;
                        }
                        else
                        {
                            Index++;
                        }
                        
                      
                    }
                }
                else
                {
                    for (int col = Col-1; col >= 0; col--)
                    {
                        string curWord = word[Index].ToString();
                        matrix[row, col] = curWord;

                        if (Index >= word.Length-1)
                        {
                            Index = 0;
                        }
                        else
                        {
                            Index++;
                        }
                       

                        
                    }
                }
               
                Count++;
            }

            for (int row = 0; row < Row; row++)
            {
                for (int col = 0; col < Col; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
