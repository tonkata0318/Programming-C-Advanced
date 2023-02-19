using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queq= new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Dictionary<string,int> delicious= new Dictionary<string,int>();
            while (queq.Count>0&&stack.Count>0)
            {
                int currrentQueq=queq.Peek();
                int currentStack = stack.Peek();
                int calculation=currrentQueq*currentStack;
                if (calculation == 150)
                {
                    if (!delicious.ContainsKey("Dipping sauce"))
                    {
                        delicious["Dipping sauce"] = 1;
                    }
                    else
                    {
                        delicious["Dipping sauce"]++;
                    }
                    queq.Dequeue();
                    stack.Pop();
                }
                else if (calculation == 250)
                {
                    if (!delicious.ContainsKey("Green salad"))
                    {
                        delicious["Green salad"] = 1;
                    }
                    else
                    {
                        delicious["Green salad"]++;
                    }
                    queq.Dequeue();
                    stack.Pop();
                }
                else if (calculation == 300)
                {
                    if (!delicious.ContainsKey("Chocolate cake"))
                    {
                        delicious["Chocolate cake"] = 1;
                    }
                    else
                    {
                        delicious["Chocolate cake"]++;
                    }
                    queq.Dequeue();
                    stack.Pop();
                }
                else if (calculation == 400)
                {
                    if (!delicious.ContainsKey("Lobster"))
                    {
                        delicious["Lobster"] = 1;
                    }
                    else
                    {
                        delicious["Lobster"]++;
                    }
                    queq.Dequeue();
                    stack.Pop();
                }
                else
                {
                    if (currrentQueq==0)
                    {
                        queq.Dequeue();
                        continue;
                    }
                    stack.Pop();
                    int temp = currrentQueq + 5;
                    queq.Dequeue();
                    queq.Enqueue(temp);
                }
            }
            int count = 0;
            foreach (var item in delicious)
            {
                count += item.Value;
            }
            if (count>=4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            if (queq.Count>0)
            {
                Console.WriteLine($"Ingredients left: {queq.Sum()}");
            }
            foreach (var item in delicious.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"# {item.Key} --> {item.Value}");
            }
        }
    }
}
