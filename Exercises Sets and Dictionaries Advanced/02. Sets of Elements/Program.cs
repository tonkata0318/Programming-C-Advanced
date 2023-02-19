using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = sizes[0];
            int m = sizes[1];
            HashSet<int> set = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var item in set)
            {
                foreach (var item2 in set2)
                {
                    if (item==item2)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
    }
}
