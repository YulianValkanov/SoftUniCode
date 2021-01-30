using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = Input[0];
            int m = Input[1];

            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {

                string[] rowData = Console.ReadLine().Split();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand=="END")
                {
                    break;
                }
                string[] comandsData = comand.Split(" ");

                if (comandsData.Length != 5||comandsData[0]!="swap")
                {
                    Console.WriteLine("Invalid input!");
                 
                    continue;
                }

                int rowOne = int.Parse(comandsData[1]);
                int colOne = int.Parse(comandsData[2]);
                int rowTwo = int.Parse(comandsData[3]);
                int colTwo = int.Parse(comandsData[4]);

                bool isValidOne = rowOne >= 0 && rowOne < n && colOne >= 0 && colOne < m;

                bool isValidTwo = rowTwo >= 0 && rowTwo < n && colTwo >= 0 && colTwo < m;

                if (!isValidOne||!isValidTwo)
                {
                    Console.WriteLine("Invalid input!");

                    continue;
                }

                string valueOne = matrix[rowOne, colOne];
                string valueTwo = matrix[rowTwo, colTwo];

                matrix[rowOne, colOne] = valueTwo;
                matrix[rowTwo, colTwo] = valueOne;

                for (int row = 0; row < n; row++)
                {


                    for (int col = 0; col < m; col++)
                    {
                        Console.Write(matrix[row,col] +" ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
