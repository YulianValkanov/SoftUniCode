﻿using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num = int.Parse(Console.ReadLine());
            int k = 1;

            while (k<=Num)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }

            
        }
    }
}
