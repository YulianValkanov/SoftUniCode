using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Code_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberApartments = 3;

            SortedDictionary<int, List<SortedDictionary<int, string>>> programing = new SortedDictionary<int, List<SortedDictionary<int, string>>>();

            int Count = 1;

            for (int i = 1; i <= numberApartments*2; i++)
            {
                SortedDictionary<int, string> currChip = new SortedDictionary<int, string>();

                currChip.Add(i, "on");

                List<SortedDictionary<int, string>> currentList = new List<SortedDictionary<int, string>> { currChip};

                if (programing.ContainsKey(Count))
                {
                    programing[Count].Add(currChip);
                }
                else
                {
                    programing.Add(Count, currentList);
                }
              
                if (i%2==0)
                {
                    Count++;
                }             
            }
            //////////////////////////////
            SortedDictionary<int, string> changStatus = new SortedDictionary<int, string>();
            changStatus.Add(4, "off");

            programing[2][1].Remove(4);
            programing[2].Add(changStatus);


            foreach (var apart in programing)
            {
                Console.WriteLine("Apartament №"+apart.Key);

                foreach (var listItem in apart.Value)
                {
                    foreach (var item in listItem.OrderBy(x=>x.Key))
                    {
                        Console.WriteLine("- Chip №" + item.Key + " with status: " + item.Value);
                    }                 
                }
            }

            /////////////////////////////

        

        }
    }
}
