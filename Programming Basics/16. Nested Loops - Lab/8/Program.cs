using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {

            int TotalTickets = 0;
            int StudentTickt = 0;
            int StandardTicket = 0;
            int KidsTicket = 0;

            while(true) //finish
            {
                string Moovie = Console.ReadLine();
                if (Moovie == "Finish") 
                {
                    break;
                }
                int capacity = int.Parse(Console.ReadLine());
                int MoovieTickets = 0;
                while (true)
                {
                    string ticetType = Console.ReadLine();
                    if (ticetType=="End")
                    {
                        break;
                    }
                    switch (ticetType)
                    {
                        case "student":
                            StudentTickt++;
                            break;
                        case "standard":
                            StandardTicket++;
                            break;
                        case "kid":
                            KidsTicket++;
                            break;
                    }

                    MoovieTickets++;
                    if (MoovieTickets>=capacity)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{Moovie} - {100.0*MoovieTickets/capacity:f2}% full.");

                TotalTickets += MoovieTickets;
            }
            Console.WriteLine($"Total tickets: {TotalTickets}");
            Console.WriteLine($"{100.0*StudentTickt/TotalTickets:f2}% student tickets.");
            Console.WriteLine($"{100.0 * StandardTicket / TotalTickets:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * KidsTicket / TotalTickets:f2}% kids tickets.");

        }
    }
}
