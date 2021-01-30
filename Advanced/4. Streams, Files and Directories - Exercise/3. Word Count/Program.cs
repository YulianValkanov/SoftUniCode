using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] searchWords= File.ReadAllLines("../../../words.txt");

            List<string> lines = new List<string>();

            string[] wordText = File.ReadAllLines("../../../text.txt");

            for (int i = 0; i < wordText.Length; i++)
            {
                lines.Add(wordText[i]);
            }

            SortedDictionary<string, int> result = new SortedDictionary<string, int>();
            for (int i = 0; i < searchWords.Length; i++)
            {
                int Count = 0;

                for (int j = 0; j < lines.Count; j++)
                {
                
                  
                    if(lines[j].ToLower().Contains(searchWords[i].ToLower()))
                    {
                        Count++;
                    }
                }

                result.Add(searchWords[i], Count);
               
            }



            using (StreamWriter writer = new StreamWriter("../../../newFile.txt"))
            {
                foreach (var item in result.OrderByDescending(x => x.Value))
                {
                    

                    writer.WriteLine($"{item.Key} - {item.Value}");
                }

            }
            }
        }
    }

