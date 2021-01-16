using System;

namespace _6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int FirstNum = 97; FirstNum < (97+n); FirstNum++)
            {
                for (int SecondNum = 97; SecondNum < (97+n); SecondNum++)
                {
                    for (int ThirthNum = 97; ThirthNum < (97+n); ThirthNum++)
                    {
                        char FirstChar = (char)(FirstNum);
                        char SecondChar = (char)(SecondNum);
                        char ThirthChar = (char)(ThirthNum);
                        Console.WriteLine($"{FirstChar}{SecondChar}{ThirthChar}");
                    }
                }
            }

           
        }
    }
}
