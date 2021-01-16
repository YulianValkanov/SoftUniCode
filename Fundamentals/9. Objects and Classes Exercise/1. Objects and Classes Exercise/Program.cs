using System;

namespace _1._Objects_and_Classes_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] Phrases = { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            string[] Events = { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();

                string massage = Phrases[rnd.Next(0,Phrases.Length)];
                string plases = Events[rnd.Next(0, Events.Length)];
                string autor = Authors[rnd.Next(0, Authors.Length)];
                string city = Cities[rnd.Next(0, Cities.Length)];

                Console.WriteLine($"{massage} {plases} {autor} – {city}");
            }
        }
    }
}
