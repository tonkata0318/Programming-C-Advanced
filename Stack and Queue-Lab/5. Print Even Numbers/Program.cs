using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input=Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ints= new Queue<int>(input);
            for (int i = 0; i < input.Length; i++)
            {
                int curNum = ints.Peek();
                if (curNum%2==0)
                {
                    if (i==input.Length-1)
                    {
                        Console.Write($"{curNum}");
                        ints.Dequeue();
                    }
                    else
                    {
                        Console.Write($"{curNum}, ");
                        ints.Dequeue();
                    }
           
                }
                else
                {
                    ints.Dequeue();
                }
            }
        }
    }
}
