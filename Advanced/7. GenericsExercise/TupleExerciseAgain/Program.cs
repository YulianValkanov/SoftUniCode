using System;
using System.Collections.Generic;
using System.Linq;

namespace TupleExerciseAgain
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ListTuple<string> newList = new ListTuple<string>();
            List<string> current1 = new List<string>(Console.ReadLine().Split(" "));
          
         
            List<string> current2 = new List<string>(Console.ReadLine().Split(" "));
            newList.MyProperty = current2;

            List<double> current3 = new List<double>(Console.ReadLine().Split(" ").Select(double.Parse));
            newList.MyProperty.Add(current3);


            
            Console.WriteLine(tuple.ToString());
        }
    }
}
