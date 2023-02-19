using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(' ').ToArray();
            int n=int.Parse(Console.ReadLine());
            Queue<string> queue=new Queue<string>(input);
            while (queue.Count>1)
            {
                string name = queue.Peek();
                for (int i = 0; i <n-1; i++)
                {
                    queue.Dequeue();
                    queue.Enqueue(name);
                    name= queue.Peek();
                }
                queue.Dequeue();
                Console.WriteLine($"Removed {name}");
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
