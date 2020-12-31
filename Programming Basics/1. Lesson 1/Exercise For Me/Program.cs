using System;

namespace Exercise_For_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Beep();
            Console.WriteLine();

            string Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hi, " + Name + "!"+
                " Hou old are you ?");
            Console.Beep();

            Console.WriteLine();
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ooo, You are " + Age + " years old. Great!");
            Console.WriteLine("Next year you will be " + (Age + 1) + " !");
            Console.Beep();
        }
    }
}
