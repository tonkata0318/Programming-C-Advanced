using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            int n=int.Parse(Console.ReadLine());
            Stack<string> queue = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];
                if (command=="1")
                {
                    string appendtext = input[1];
                    text += appendtext;
                    queue.Push(text);
                }
                else if (command=="2")
                {
                    int count = int.Parse(input[1]);
                    text=text.Substring(0,text.Length-count);
                    queue.Push(text);
                }
                else if (command=="3")
                {
                    int index = int.Parse(input[1]);
                    index = index - 1;
                    Console.WriteLine(text[index]);
                }
                else if (command=="4")
                {
                    if (queue.Count==1)
                    {
                        queue.Pop();
                        text = "";
                    }
                    else
                    {
                        queue.Pop();
                        text = queue.Peek();
                    }
                }
            }
        }
    }
}
