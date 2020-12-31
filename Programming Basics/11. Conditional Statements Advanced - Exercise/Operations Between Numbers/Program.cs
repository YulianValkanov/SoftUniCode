using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string Operator = Console.ReadLine();

            double Result = 0;
           
           

            switch(Operator)
            {
                case ("+"):
                    Result = N1 + N2;
               
                    if (Result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {Operator} {N2} = {Result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {Operator} {N2} = {Result} - odd");
                    }
                    break;

                case ("-"):
                    Result = N1 - N2;
                    if (Result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {Operator} {N2} = {Result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {Operator} {N2} = {Result} - odd");
                    }
                    break;

                case ("*"):
                    Result = N1 * N2;
                    if (Result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {Operator} {N2} = {Result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {Operator} {N2} = {Result} - odd");
                    }
                    break;

                case ("/"):
                    if(N2!=0)
                    {
                        Result = N1 / N2;
                        Console.WriteLine($"{N1} / {N2} = {Result:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    
                    break;

                case ("%"):
                    if (N2 != 0)
                    {
                        Result = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {Result}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
            }

       
          


            
        }
    }
}
