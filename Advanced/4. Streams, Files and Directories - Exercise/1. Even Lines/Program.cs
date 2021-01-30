using System;
using System.IO;
using System.Linq;

namespace _8._Streams__Files_and_Directories___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();

                int Counter = 0;
                while (line!=null)
                {
                    if (Counter%2==0)
                    {
                        string[] words = new string[] { "-", ",", ".", "!", "?" };

                        for (int i = 0; i < words.Length; i++)
                        {
                         line=   line.Replace(words[i], "@");

                          
                        }
                        string[] newww = line.Split(" ");

                      

                        Console.WriteLine(string.Join(" ",newww.Reverse()));
                    }


                    line = reader.ReadLine();

                    Counter++;
                }
            }
        }
    }
}
