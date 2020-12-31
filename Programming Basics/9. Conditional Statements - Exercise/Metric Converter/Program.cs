    using System;

    namespace Metric_Converter
    {
        class Program
        {
            static void Main(string[] args)
            {

                double Num = double.Parse(Console.ReadLine());
                string Inn = Console.ReadLine();
                string Out = Console.ReadLine();

                if (Inn == "m")
                {
                    if (Out == "cm")
                    {
                        double result = Num * 100;
                        Console.WriteLine($"{result:f3}");
                    }
                    else
                    {
                        double result = Num * 1000;
                        Console.WriteLine($"{result:f3}");
                    }
                
               
                }
                else if (Inn == "cm")
                {
                    if (Out == "m")
                
                    {
                        double result = Num / 100;
                        Console.WriteLine($"{result:f3}");
                    }
                    else
                    {
                        double result = Num * 10;
                        Console.WriteLine($"{result:f3}");
                    }
                }
                else
                {
                    if (Out == "cm")
                    {
                        double result = Num / 10;
                        Console.WriteLine($"{result:f3}");
                    }              
                    else
                    {
                        double result = Num / 1000;
                        Console.WriteLine($"{result:f3}");
                    }
                }
           
            }
        }
    }
