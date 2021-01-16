using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string Imput = string.Empty;
            int Counter = 0;
            int BestCount = 0;
            int BestBeginIndex = 0;
            int Bestsum = 0;
            string BestSiquense = "";
            int bestCounter = 0;

            while ((Imput= Console.ReadLine())!="Clone them!")
            {
                string siquenses = Imput.Replace("!", "");

                string[] dnkParts = siquenses.Split("0",StringSplitOptions.RemoveEmptyEntries);

                int Count = 0;
                int Sum = 0;
                string BestSub = "";
                Counter++;

                foreach (string dnkPart in dnkParts)
                {
                    if (dnkPart.Length>Count)
                    {
                        Count = dnkPart.Length;
                        BestSub = dnkPart;
                    }
                    Sum += dnkPart.Length;
                }

                int BeginIndex = siquenses.IndexOf(BestSub);

                if (Count > BestCount||
                    (Count == BestCount && BeginIndex < BestBeginIndex)||
                    (Count==BestCount&&BeginIndex==BestBeginIndex&&Sum>Bestsum)||
                    Counter==1)
                {
                    BestCount = Count;
                    BestSiquense = siquenses;
                    BestBeginIndex = BeginIndex;
                    Bestsum = Sum;
                    bestCounter = Counter;
                }
            }
            char[] result = BestSiquense.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {Bestsum}.");
            Console.WriteLine($"{string.Join(" ",result)}");

        }
    }
}
