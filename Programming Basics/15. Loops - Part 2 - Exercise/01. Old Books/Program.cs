using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {

            string NameBook = Console.ReadLine();
            int Number = int.Parse(Console.ReadLine());
            bool isFound = false;
            int Count = 0;

            while(isFound==false)
            {
                string OtherBooks = Console.ReadLine();
                if (OtherBooks==NameBook)
                {
                    isFound = true;
                }
                else
                {
                    Count++;
                    if(Count>=Number)
                    {
                        break;
                    }
                }
            }
            if(isFound==true)
            {
                Console.WriteLine($"You checked {Count} books and found it."); 
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {Count} books.");
            }

        }
    }
}
