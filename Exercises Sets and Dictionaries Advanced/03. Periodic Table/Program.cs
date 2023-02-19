﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                for (int j = 0; j < input.Length; j++)
                {
                    set.Add(input[j]);
                }
            }
            foreach (var item in set.OrderBy(x=>x))
            {
                Console.Write($"{item} ");
            }
        }
    }
}
