using System;
using System.Collections.Generic;

namespace _2._Sinonims
{
    class Program
    {
        public static object Dictyonary { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictyonary<string, List<string> > dictyonary = new Dictyonary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinonim = Console.ReadLine();

                if (dictyonary.ContainsKey(word))
                {
                    dictyonary[word].Add(sinonim);
                }
                else
                {
                    dictyonary.Add
                }
            }
        }
    }
}
