using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();

            while (comand!="buy")
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
                Console.WriteLine(item);
            }
        }
    }
}
