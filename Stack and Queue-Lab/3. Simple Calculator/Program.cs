using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine().Split(' ').ToArray();
            Stack<string> stack=new Stack<string>();
            int result = 0;
            for (int i = input.Length-1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }
            int counter = 0;
            int thelastEl = 0;
            while (stack.Count>0)
            {
                if (counter==0)
                {
                    thelastEl = int.Parse(stack.Pop());
                    counter++;
                }
                else
                {
                    thelastEl = 0; 
                }
                string operation=stack.Pop();
                int secondEl = int.Parse(stack.Pop());
                if (operation=="+")
                {
                    result += thelastEl + secondEl;
                }
                else if (operation=="-")
                {
                    result+=thelastEl-secondEl;
                }
            }
            Console.WriteLine(result);
        }
    }
}
