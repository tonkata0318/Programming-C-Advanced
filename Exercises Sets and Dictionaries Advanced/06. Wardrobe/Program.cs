using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,int>> clothes=new Dictionary<string,Dictionary<string,int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothesToAdd = input[1].Split(",").ToArray();
                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < clothesToAdd.Length; j++)
                {
                    if (clothes[color].ContainsKey(clothesToAdd[j]))
                    {
                        clothes[color][clothesToAdd[j]]++;
                    }
                    else
                    {
                        clothes[color].Add(clothesToAdd[j], 1);
                    }
                }
            }
            string[] itemToLookFor = Console.ReadLine().Split(' ');
            string colorToLookFor = itemToLookFor[0];
            string clotheToLookFor = itemToLookFor[1];
            bool ColourMach=false;
            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");
                if (item.Key==colorToLookFor)
                {
                    ColourMach = true;
                }
                foreach (var item2 in item.Value)
                {
                    if (ColourMach)
                    {
                        if (item2.Key==clotheToLookFor)
                        {
                            Console.WriteLine($"* {item2.Key} - {item2.Value} (found!)");
                            ColourMach= false;
                            continue;
                        }
                    }
                    Console.WriteLine($"* {item2.Key} - {item2.Value}");
                }
            }
        }
    }
}
