using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue<int> steel=new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
           Stack<int> carbon=new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Dictionary<string,int> swords=new Dictionary<string,int>();
            int count = 0;
            while (steel.Count>0&&carbon.Count>0)
            {
                int currentSteel = steel.Peek();
                int currentCarbon = carbon.Peek();
                if (currentSteel+currentCarbon==70)
                {
                    if (!swords.ContainsKey("Gladius"))
                    {
                        swords["Gladius"] = 1;
                    }
                    else
                    {
                        swords["Gladius"]++;
                    }
                    steel.Dequeue();
                    carbon.Pop();
                    count++;
                }
                else if (currentSteel + currentCarbon == 80)
                {
                    if (!swords.ContainsKey("Shamshir"))
                    {
                        swords["Shamshir"] = 1;
                    }
                    else
                    {
                        swords["Shamshir"]++;
                    }
                    steel.Dequeue();
                    carbon.Pop();
                    count++;
                }
                else if (currentSteel + currentCarbon == 90)
                {
                    if (!swords.ContainsKey("Katana"))
                    {
                        swords["Katana"] = 1;
                    }
                    else
                    {
                        swords["Katana"]++;
                    }
                    steel.Dequeue();
                    carbon.Pop();
                    count++;
                }
                else if (currentSteel + currentCarbon == 110)
                {
                    if (!swords.ContainsKey("Sabre"))
                    {
                        swords["Sabre"] = 1;
                    }
                    else
                    {
                        swords["Sabre"]++;
                    }
                    steel.Dequeue();
                    carbon.Pop();
                    count++;
                }
                else if (currentSteel + currentCarbon == 150)
                {
                    if (!swords.ContainsKey("Broadsword"))
                    {
                        swords["Broadsword"] = 1;
                    }
                    else
                    {
                        swords["Broadsword"]++;
                    }
                    steel.Dequeue();
                    carbon.Pop();
                    count++;
                }
                else
                {
                    steel.Dequeue();
                    currentCarbon += 5;
                    carbon.Pop();
                    carbon.Push(currentCarbon);
                }
            }
            if (count>0)
            {
                Console.WriteLine($"You have forged {count} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            if (steel.Count>0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ",steel)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }
            if (carbon.Count>0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ",carbon)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }
            foreach (var item in swords.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
