using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
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
                    dictyonary.Add(word, new List<string>() { sinonim});
                }
            }


            foreach (var word in dictyonary)
            {

            }
        }
    }
}
