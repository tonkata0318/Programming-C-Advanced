using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Dictionary<string,int> places=new Dictionary<string,int>();
            while (stack.Count>0&&queue.Count>0)
            {
                if (stack.Peek()==queue.Peek())
                {
                    int tailsArea = stack.Pop() + queue.Dequeue();
                    if (tailsArea==40)
                    {
                        if (!places.ContainsKey("Sink"))
                        {
                            places["Sink"] = 1;
                        }
                        else
                        {
                            places["Sink"]++;
                        }
                    }
                    else if (tailsArea == 50)
                    {
                        if (!places.ContainsKey("Oven"))
                        {
                            places["Oven"] = 1;
                        }
                        else
                        {
                            places["Oven"]++;
                        }
                    }
                    else if (tailsArea == 60)
                    {
                        if (!places.ContainsKey("Countertop"))
                        {
                            places["Countertop"] = 1;
                        }
                        else
                        {
                            places["Countertop"]++;
                        }
                    }
                    else if (tailsArea == 70)
                    {
                        if (!places.ContainsKey("Wall"))
                        {
                            places["Wall"] = 1;
                        }
                        else
                        {
                            places["Wall"]++;
                        }
                    }
                    else
                    {
                        if (!places.ContainsKey("Floor"))
                        {
                            places["Floor"] = 1;
                        }
                        else
                        {
                            places["Floor"]++;
                        }
                    }
                }
                else
                {
                    int stacktemp=stack.Pop()/2;
                    stack.Push(stacktemp);
                    int temp=queue.Dequeue();
                    queue.Enqueue(temp);
                }
            }
            if (stack.Count>0)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ",stack)}");
            }
            else
            {
                Console.WriteLine($"White tiles left: none");
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ",queue)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }
            foreach (var item in places.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
