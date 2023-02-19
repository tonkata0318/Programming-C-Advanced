using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _1.Barista_Contest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queq = new Queue<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Dictionary<string, int> drinks = new Dictionary<string, int>();
            int sum = 0;
            bool win = false;
            while (queq.Count > 0 && stack.Count > 0)
            {
                sum = queq.Peek() + stack.Peek();
                if (sum == 50)
                {
                    if (!drinks.ContainsKey("Cortado"))
                    {
                        drinks["Cortado"] = 1;
                    }
                    else
                    {
                        drinks["Cortado"] += 1;
                    }
                    queq.Dequeue();
                    stack.Pop();
                }
                else if (sum == 75)
                {
                    if (!drinks.ContainsKey("Espresso"))
                    {
                        drinks["Espresso"] = 1;
                    }
                    else
                    {
                        drinks["Espresso"] += 1;
                    }
                    queq.Dequeue();
                    stack.Pop();
                }
                else if (sum == 100)
                {
                    if (!drinks.ContainsKey("Capuccino"))
                    {
                        drinks["Capuccino"] = 1;
                    }
                    else
                    {
                        drinks["Capuccino"] += 1;
                    }
                    queq.Dequeue();
                    stack.Pop();
                }
                else if (sum == 150)
                {
                    if (!drinks.ContainsKey("Americano"))
                    {
                        drinks["Americano"] = 1;
                    }
                    else
                    {
                        drinks["Americano"] += 1;
                    }
                    queq.Dequeue();
                    stack.Pop();
                }
                else if (sum == 200)
                {
                    if (!drinks.ContainsKey("Latte"))
                    {
                        drinks["Latte"] = 1;
                    }
                    else
                    {
                        drinks["Latte"] += 1;
                    }
                    queq.Dequeue();
                    stack.Pop();
                }
                else
                {
                    queq.Dequeue();
                    int time = stack.Pop()-5;
                    stack.Push(time);
                }
            }
            if (stack.Count == 0 && queq.Count == 0)
            {
                win = true;
            }
            if (win)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }
            if (queq.Count > 0)
            {
                Console.WriteLine($"Coffee left: {string.Join(" ", queq)}");
            }
            else
            {
                Console.WriteLine("Coffee left: none");
            }
            if (stack.Count > 0)
            {
                Console.WriteLine($"Milk left: {string.Join(" ", stack)}");
            }
            else
            {
                Console.WriteLine($"Milk left: none");
            }
            foreach (var item in drinks.OrderBy(x=>x.Value).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
