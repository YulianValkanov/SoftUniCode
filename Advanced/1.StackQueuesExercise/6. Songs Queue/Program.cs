using System;
using System.Collections.Generic;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(Input);

            string comands = Console.ReadLine();

            while (songs.Count>0)
            {
                if (comands=="Play")
                {
                    songs.Dequeue();
                }
                else if (comands== "Show")
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
                else
                {
                    string songAdds = comands.Substring(4);

                    if (songs.Contains(songAdds))
                    {
                        Console.WriteLine($"{songAdds} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songAdds);
                    }
                    
                }



                comands = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
