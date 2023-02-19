using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Dictionary<double, int> dict = new Dictionary<double, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(array[i]))
                {
                    dict[array[i]]++;
                }
                else
                {
                    dict.Add(array[i], 1);
                }
            }
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }

        }
    }
}
