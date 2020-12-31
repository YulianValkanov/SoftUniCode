using System;

namespace Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {

            string Pass = Console.ReadLine();

            if (Pass == "s3cr3t!P@ssw0rd")
            {

                Console.WriteLine("Welcome");
            }
            else
            {

                Console.WriteLine("Wrong password!");
            }
        }
    }
}
