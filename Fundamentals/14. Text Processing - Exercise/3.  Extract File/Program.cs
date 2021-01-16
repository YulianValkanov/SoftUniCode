using System;
using System.Linq;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            string[] newString = input.Split(@"\");

            string[] noviqt = newString[newString.Length - 1].Split(".");

            Console.WriteLine($"File name: {noviqt[0]}");

            Console.WriteLine($"File extension: {noviqt[1]}");
        }
    }
}
