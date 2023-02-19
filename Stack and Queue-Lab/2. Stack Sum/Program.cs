using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] array=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                stack.Push(array[i]);
            }
            string command;
            while ((command=Console.ReadLine())!="end")
            {
                string[] cmdInfo=command.Split(" ");
                string firstCommand = cmdInfo[0].ToLower();
                if (firstCommand=="add")
                {
                    int firstNumber = int.Parse(cmdInfo[1]);
                    int secondNumber = int.Parse(cmdInfo[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (firstCommand=="remove")
                {
                    int firstNumber = int.Parse(cmdInfo[1]);
                    if (stack.Count>=firstNumber)
                    {
                        for (int i = 0; i < firstNumber; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (firstCommand=="end")
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
