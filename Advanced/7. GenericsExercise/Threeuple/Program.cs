using System;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 1;

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (Count==1)
                {
                    string first = "";
                    string second = "";
                    string thirth= "";


                    if (input.Length>4)
                    {
                     first = $"{ input[0] } {input[1]}";
                     second = $"{input[2]}";
                         thirth = $"{input[3]} {input[4]}";
                    }
                    else
                    {
                         first = $"{ input[0] } {input[1]}";
                         second = $"{input[2]}";
                         thirth = $"{input[3]}";
                    }
                

                    Threeuplee<string, string, string> threeuple1 = new Threeuplee<string, string, string>(first, 
                        second, thirth);
                    Console.WriteLine(threeuple1.ToString());
                }
                else if (Count==2)
                {
                    string first = $"{ input[0] }";
                    int second = int.Parse(input[1]);
                    string thirth = $"{input[2]}";

                    bool drink= isDrunk(thirth);

                    

                    Threeuplee<string, int, bool> threeuple2 = new Threeuplee<string, int, bool>(first, second, drink);
                    Console.WriteLine(threeuple2.ToString());

                }
                else if (Count == 3)
                {
                    string first = $"{ input[0] }";
                    double second = double.Parse(input[1]);
                    string thirth = $"{input[2]}";

                   

                    Threeuplee<string, double, string> threeuple3 = new Threeuplee<string, double, 
                        string>(first, second, thirth);
                    Console.WriteLine(threeuple3.ToString());


                }
                Count++;
            }

           


          

          

        }

        private static bool isDrunk(string thirth)
        {
            bool isDrunk = false;
            if (thirth == "drunk")
            {
                isDrunk = true;
            }
            else if (thirth == "not")
            {
                isDrunk = false;
            }

            return isDrunk;
        }
    }
}
