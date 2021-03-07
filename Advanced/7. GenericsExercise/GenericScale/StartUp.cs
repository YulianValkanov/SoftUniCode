using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {        
            EqualityScale<string> newQ = new EqualityScale<string>("a", "a");
            Console.WriteLine(newQ.AreEqual());

            ///////////////////////////////////////////

            string[] currArr = Console.ReadLine().Split(" ");


            BooklistArray bookArray = new BooklistArray();

            while (currArr[0]!="stop")
            {
                Book book = new Book(currArr[0], currArr[1], int.Parse(currArr[2]));

                bookArray.ADD(book);

                currArr = Console.ReadLine().Split(" ");
            }

            bookArray.Printer();








        }

       
    }
}
