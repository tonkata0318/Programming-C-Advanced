using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    stack.Push(i);
                }
                else if (input[i]==')')
                {
                    int startindex = stack.Pop();
                    for (int j = startindex; j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
