using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parcingCars = new Dictionary<string, string>();


            for (int i = 0; i < n; i++)
            {
                List<string> imput = Console.ReadLine().Split(" ").ToList();

                string comand = imput[0];
                string user = imput[1];
                

                if (comand== "register")
                {

                    string registrationNumber = imput[2];
                    if (!parcingCars.ContainsKey(user))
                    {
                        parcingCars.Add(user, registrationNumber);
                        Console.WriteLine($"{user} registered {registrationNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registrationNumber}");
                    }
                    
                }
              
                else if (comand== "unregister")
                {
                    if (!parcingCars.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        parcingCars.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }


                
            }

            foreach (var item in parcingCars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
