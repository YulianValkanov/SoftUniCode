using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._ForceBook
{
    class Program
    {
        static void Main(string[] args)

        {


            SortedDictionary<string, List<string>> users = new SortedDictionary<string, List<string>>();

            SortedDictionary<string, List<string>> joiners = new SortedDictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] currentUser = input.Split(" | ");

                    string forceSide = currentUser[0];
                    string forceUser = currentUser[1];

                    List<string> listUsers = new List<string>();
                    listUsers.Add(forceUser);

                    //ako sadarja
                    if (users.ContainsKey(forceSide))
                    {
                        //ako ne sashtestvuva usera v saotvetnata strana
                        if (!users[forceSide].Contains(forceUser))
                        {
                            users[forceSide].Add(forceUser);
                        }
                       
                    }
                    //ne sadarja
                    else
                    {
                        users.Add(forceSide, listUsers);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] currentUser = input.Split(" -> ");

                    string forceSide = currentUser[1];

                    string forceUser = currentUser[0];

                    bool isExist = false;
                    foreach (var item in users)
                    {
                        foreach (var people in item.Value)
                        {
                            if (people==forceUser)
                            {
                                isExist = true;
                            }
                        }
                    }


                    if (isExist==true)
                    {
                        if (users[forceSide].Contains(forceUser))
                        {
                            
                        }
                        else
                        {
                            foreach (var item in users)
                            {
                                users[item.Key].Remove(forceUser);
                            }
                            users[forceSide].Add(forceUser);

                            Console.WriteLine($"{forceUser} joins the Lighter side!");
                        }

                       
                    }
                    else
                    {
                        users[forceSide].Add(forceUser);

                        Console.WriteLine($"{forceUser} joins the Lighter side!");
                    }

                    

                    
                }

                input = Console.ReadLine();
            }





            foreach (var item in users.OrderByDescending(x=>x.Value.Count))
            {
                if (item.Value.Count==0)
                {
                    continue;
                }
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var what in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"! {what}");
                }
               
            }

        }
    }
}
