using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guests = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int wastedFood = 0;
            while (guests.Count>0&&plates.Count>0)
            {
                int currentGuest = guests.Peek();
                int cuurentPlate=plates.Peek();
                if (currentGuest>cuurentPlate)
                {
                    currentGuest-=cuurentPlate;
                    plates.Pop();
                    while (currentGuest>0&&plates.Count>0)
                    {
                        currentGuest-=plates.Peek();
                        if (currentGuest<=0)
                        {
                            int diff=Math.Abs(currentGuest);
                            plates.Pop();
                            wastedFood += diff;
                        }
                        else
                        {
                            plates.Pop();
                        }
                    }
                    if (currentGuest<=0)
                    {
                        guests.Dequeue();
                    }
                    else
                    {
                        guests.Dequeue();
                        guests.Enqueue(currentGuest);
                        wastedFood+= currentGuest;
                    }
                }
                else if (cuurentPlate>=currentGuest)
                {
                    int diff = cuurentPlate - currentGuest;
                    wastedFood += diff;
                    guests.Dequeue();
                    plates.Pop();
                }
            }
            if (plates.Count > 0)
            {
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            }
            else if (guests.Count > 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            }
            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
