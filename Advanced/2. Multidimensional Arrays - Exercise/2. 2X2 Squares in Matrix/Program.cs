using System;
using System.Linq;

namespace _2._2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int Row = input[0];
            int Col = input[1];

            string[,] matrix = new string[Row, Col];

            for (int row = 0; row < Row; row++)
            {
                string[] matrixArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < Col; col++)
                {
                    matrix[row, col] = matrixArray[col];


                }
            }

            int index = 0;
            int Count = 0;

            for (int row = 0; row < Row-1; row++)
            {
                for (int col = 0; col < Col-1; col++)
                {
                    if (matrix[row,col]==matrix[row,col+1]&&
                        matrix[row,col]==matrix[row+1,col]&&
                      
                       matrix[row,col]==matrix[row+1,col+1])
                    {
                        Count++;
                    }
                }
            }

            Console.WriteLine(Count);
        }
    }
}
