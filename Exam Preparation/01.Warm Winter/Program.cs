using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats= new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> sets = new Queue<int>();
            while (hats.Count>0&&scarfs.Count>0)
            {
                int currentHat=hats.Peek();
                int currentScarfs=scarfs.Peek();
                if (currentHat>currentScarfs)
                {
                    int set=currentHat+currentScarfs;
                    sets.Enqueue(set);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (currentHat==currentScarfs)
                {
                    scarfs.Dequeue();
                    int temp = currentHat + 1;
                    hats.Pop();
                    hats.Push(temp);
                }
                else if (currentScarfs>currentHat)
                {
                    hats.Pop();
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine($"{string.Join(" ",sets)}");
        }
    }
}
