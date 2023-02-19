using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequences=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int capofRacr=int.Parse(Console.ReadLine());
            Stack<int> stack=new Stack<int>(sequences);
            int curRag = 0;
            int count = 0;
            while (stack.Count>0)
            {
                curRag = curRag + stack.Peek();
                if (curRag<16&&stack.Count==1)
                {
                    count++;
                }
                if (curRag>capofRacr)
                {
                    curRag=0;
                    count++;
                }
                else if (curRag==capofRacr&&stack.Count>1)
                {
                    curRag = 0;
                    count++;
                    stack.Pop();
                }
                else 
                {
                    stack.Pop();
                }
            }
            Console.WriteLine(count);
        }
    }
}
