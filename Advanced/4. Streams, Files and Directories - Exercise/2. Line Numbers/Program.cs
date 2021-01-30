using System;
using System.Collections.Generic;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            List<char> charecters = new List<char>() { '-', ',', '.', '!', '?' , '\''};

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                int letters = 0;
                int notLetter = 0;

                foreach (var ch in line)
                {
                    if (char.IsLetter(ch))
                    {
                        letters++;

                    }
                    else if (charecters.Contains(ch))
                    {
                        notLetter++;
                    }
                }

                string newline = $"Line {i+1}: -Quick, hide here. It is safer. ({letters})({notLetter})";

                File.AppendAllText("../../../output.txt", newline+Environment.NewLine);
            }
        }
    }
}
