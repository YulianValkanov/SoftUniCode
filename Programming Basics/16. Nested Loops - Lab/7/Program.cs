using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int Floors = int.Parse(Console.ReadLine());
            int Rooms = int.Parse(Console.ReadLine());
            string Type = "";
            for (int row = Floors; row >= 1; row--)
            {
                for (int col = 0; col < Rooms; col++)
                {
                    if(row==Floors)
                    {
                        Type = "L";
                    }
                    else
                    {
                        if (row % 2 == 0)
                        {
                            Type = "O";
                        }
                        else
                        {
                            Type = "A";
                        }
                    }
                   
                    Console.Write($"{Type}{row}{col} ");
                }
                Console.WriteLine();
            }


            
        }
    }
}
