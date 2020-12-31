using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {

            string Comand = Console.ReadLine();
            int Shirina = int.Parse(Console.ReadLine());
            int Daljina = int.Parse(Console.ReadLine());
            int Visochina = int.Parse(Console.ReadLine());

            int Kashon = 1 * 1 * 1;
            int Room = Shirina * Daljina * Visochina;
            int RoomFull = 0;

            while (Comand!="Done")
            {               
                int Count = int.Parse(Console.ReadLine());
                int Now = Count * Kashon;
                RoomFull += Now;
                if (Room > RoomFull)
                {
                    Console.WriteLine($"{Room - RoomFull} Cubic meters left.");

                }
                else
                {
                    Console.WriteLine($"No more free space! You need {RoomFull - Room} Cubic meters more.");
                }

            }
            
        }
    }
}
