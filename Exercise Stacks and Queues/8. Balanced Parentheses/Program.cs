using System;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;
            foreach (char characters in input)
            {
                if (characters=='{')
                {
                    stack.Push(characters);
                }
                else if (characters=='}')
                {
                    if (stack.Count!=0)
                    {
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                        }
                    }
                    else
                    {
                        isBalanced= false;
                    }
                }
                else if (characters=='[')
                {
                    stack.Push(characters);
                }
                else if (characters==']')
                {
                    if (stack.Count != 0)
                    {
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                        }
                    }
                    else
                    {
                        isBalanced= false;
                    }
                }
                else if (characters=='(')
                {
                    stack.Push(characters);
                }
                else if (characters==')')
                {
                    if (stack.Count != 0)
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                        }
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
