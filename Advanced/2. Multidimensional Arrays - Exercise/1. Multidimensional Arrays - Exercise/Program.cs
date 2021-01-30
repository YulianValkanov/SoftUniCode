using System;
using System.Linq;

namespace _4._Multidimensional_Arrays___Exercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            int diagonalA = 0;
            int Counter = n-1;
            int diagonalB = 0;
            for (int row = 0; row < n; row++)
            {
                diagonalA+=(matrix[row,row]);

                diagonalB += matrix[row, Counter];

                     Counter--;
            }



            Console.WriteLine( Math.Abs( diagonalA-diagonalB));

 
        }
    }
}
