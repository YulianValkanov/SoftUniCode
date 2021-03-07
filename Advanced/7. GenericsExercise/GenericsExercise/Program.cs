using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());

            List<double> list = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double current = double.Parse(Console.ReadLine());

                list.Add(current);
            }

            double x = double.Parse(Console.ReadLine());

            Console.WriteLine(MethoodCompare(list, x));

           

        }

        public static int  MethoodCompare<T>(List<T> list, T X)
        {
            string Y = X.ToString();

            int sum = 0;
        
            for (int i = 0; i < Y.Length; i++)
            {
                sum += (int)Y[i];
                   
            }

            int CounrResult = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int count = 0;

                string currentT = list[i].ToString();

                for (int j   = 0; j < currentT.Length; j++)
                {
                    count += (int)currentT[j];
                }

                if (count>sum)
                {
                    CounrResult++;
                }
                
            }

            return CounrResult;
        }
    }
}
