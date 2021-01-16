using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string[] comand = Console.ReadLine().Split(" ");

            while (comand[0] != "End")
            {
                string activiti = comand[0];
                int index = int.Parse(comand[1]);
                int power = int.Parse(comand[2]);

                switch (activiti)
                {

                    case "Shoot":
                        if (index < array.Count && index >= 0)
                        {
                            array[index] -= power;
                            if (array[index] <= 0)
                            {
                                array.RemoveAt(index);
                            }
                        }

                        break;

                    case "Add":
                        if (index < array.Count && index >= 0)
                        {
                            array.Insert(index, power);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;

                    case "Strike":
                        if (index < array.Count && index >= 0)
                        {
                            
                            for (int i = index - power; i <= index + power; i++)
                            {
                                if (i >= 0 && i < array.Count)
                                {
                                    array.RemoveAt(i);
                                }
                            }
                            
                           

                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;

                }



                comand = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join("|", array));
        }
    }
    
}
