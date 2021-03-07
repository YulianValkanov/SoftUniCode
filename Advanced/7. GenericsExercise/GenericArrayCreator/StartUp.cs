using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] Strr = ArrayCreator.Create(5, "Pesho");


            Console.WriteLine(string.Join(" ",Strr));


        }

       
    }
}
