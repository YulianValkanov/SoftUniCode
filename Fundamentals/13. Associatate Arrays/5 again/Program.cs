using System;
using System.Collections.Generic;

namespace _5_again
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();


            string comand = Console.ReadLine();

            while (comand != "buy")
            {

                string[] currentProdunt = comand.Split(" ");
                string product = currentProdunt[0];
                double price = double.Parse(currentProdunt[1]);
                double quantyty = double.Parse(currentProdunt[2]);

                if (!orders.ContainsKey(product))
                {
                    List<double> priceAndQauntitu = new List<double> { price, quantyty };
                    orders.Add(product, priceAndQauntitu);
                }
                else
                {
                    orders[product][0] = price;
                    orders[product][1] += quantyty;

                }
                comand = Console.ReadLine();
            }

            foreach (var item in orders)
            {

                double result = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key:f2} -> {result:f2}");
            }
        }
    }
}
