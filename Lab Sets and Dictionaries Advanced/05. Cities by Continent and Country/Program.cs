using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dic = new Dictionary<string, Dictionary<string, List<string>>>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!dic.ContainsKey(continent))
                {
                    dic[continent] = new Dictionary<string, List<string>>(); 
                }
                if (!dic[continent].ContainsKey(country))
                {
                    dic[continent].Add(country, new List<string>());
                }
                dic[continent][country].Add(city);

            }
            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key}: ");
                foreach (var item in kvp.Value)
                {
                    Console.Write($" {item.Key} -> ");
                    Console.Write($"{string.Join(", ",item.Value)}");
                    Console.WriteLine();
                }
            }
        }
    }
}
