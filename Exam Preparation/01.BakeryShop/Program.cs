using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ").Select(double.Parse));
            Stack<double> floor = new Stack<double>(Console.ReadLine().Split(" ").Select(double.Parse));
            Dictionary<string, int> bakes = new Dictionary<string, int>();
            while (water.Count>0&&floor.Count>0)
            {
                double currentWater = water.Peek();
                double currentFloor = floor.Peek();
                double waterpercentage = (currentWater * 100) / (currentWater + currentFloor);
                if (waterpercentage==40)
                {
                    if (!bakes.ContainsKey("Muffin"))
                    {
                        bakes["Muffin"] = 1;
                    }
                    else
                    {
                        bakes["Muffin"]++;
                    }
                    water.Dequeue();
                    floor.Pop();
                }
                else if (waterpercentage==50)
                {
                    if (!bakes.ContainsKey("Croissant"))
                    {
                        bakes["Croissant"] = 1;
                    }
                    else
                    {
                        bakes["Croissant"]++;
                    }
                    water.Dequeue();
                    floor.Pop();
                }
                else if (waterpercentage==30)
                {
                    if (!bakes.ContainsKey("Baguette"))
                    {
                        bakes["Baguette"] = 1;
                    }
                    else
                    {
                        bakes["Baguette"]++;
                    }
                    water.Dequeue();
                    floor.Pop();
                }
                else if (waterpercentage==20)
                {
                    if (!bakes.ContainsKey("Bagel"))
                    {
                        bakes["Bagel"] = 1;
                    }
                    else
                    {
                        bakes["Bagel"]++;
                    }
                    water.Dequeue();
                    floor.Pop();
                }
                else
                {
                    if (currentFloor>=currentWater)
                    {
                        double remaining = currentFloor - currentWater;
                        currentFloor = currentWater;
                        water.Dequeue();
                        floor.Pop();
                        floor.Push(remaining);
                        if (!bakes.ContainsKey("Croissant"))
                        {
                            bakes["Croissant"] = 1;
                        }
                        else
                        {
                            bakes["Croissant"]++;
                        }
                    }
                    else if (currentWater>=currentFloor)
                    {
                        double remaining = currentWater - currentFloor;
                        currentWater = currentFloor;
                        water.Dequeue();
                        floor.Pop();
                        floor.Push(remaining);
                        if (!bakes.ContainsKey("Croissant"))
                        {
                            bakes["Croissant"] = 1;
                        }
                        else
                        {
                            bakes["Croissant"]++;
                        }
                    }
                }
            }
            foreach (var item in bakes.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            if (water.Count>0)
            {
                Console.WriteLine($"Water left: {string.Join(", ",water)}");
            }
            else
            {
                Console.WriteLine("Water left: None");
            }
            if (floor.Count>0)
            {
                Console.WriteLine($"Flour left: {string.Join(", ", floor)}");
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}
