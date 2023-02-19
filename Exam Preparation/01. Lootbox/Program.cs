using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int value=0;
            while (firstBox.Count>0&&secondBox.Count>0)
            {
                int sum = firstBox.Peek() + secondBox.Peek();
                if (sum%2==0)
                {
                    value += sum;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    int itemFromSecondBox = secondBox.Pop();
                    firstBox.Enqueue(itemFromSecondBox);
                }
            }
            if (firstBox.Count<=0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox.Count<=0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (value>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {value}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {value}");
            }
        }
    }
}
