using System;
using System.Linq;

namespace _8._ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ",Console.ReadLine()
                .Split()
                .Reverse()));
                
        }
    }
}
