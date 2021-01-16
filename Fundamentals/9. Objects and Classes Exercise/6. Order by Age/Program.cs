using System;

using System.Collections.Generic;
using System.Linq;

namespace _6._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            List<Order> orders = new List<Order> ();

            while (input[0]!="End")
            {
                string name = input[0];
                int fnom = int.Parse(input[1]);
                int age = int.Parse(input[2]);

                Order dada = new Order(name, fnom, age);
                orders.Add(dada);


                input = Console.ReadLine().Split(" ");
            }
            orders= orders.OrderByDescending(a => a.Age).Reverse().ToList();

            Console.WriteLine(string.Join(Environment.NewLine,orders));
        }

        class Order
        {
            public Order(string name, int fnom, int age)
            {
                Name = name;
                fNum = fnom;
                Age = age;
            }

            public string Name { get; set; }

            public int fNum { get; set; }

            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {fNum} is {Age} years old.";
            }
        }
    }
}
