using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Windows.Input;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs=Console.ReadLine().Split(", ").ToArray();
            Queue<string> queue = new Queue<string>(songs);
            while (queue.Count>0)
            {
                string[] cmdInfo=Console.ReadLine().Split(' ');
                string command = cmdInfo[0];
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Add")
                {
                    string songToAdd = "";
                    for (int i = 1; i < cmdInfo.Length; i++)
                    {
                        if (i==cmdInfo.Length-1)
                        {
                            songToAdd += cmdInfo[i];
                        }
                        else
                        {
                            songToAdd += cmdInfo[i] + " ";
                        }
                    }
                    if (queue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(songToAdd);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
            }
            Console.WriteLine("No more songs!");
            Environment.Exit(0);
        }
    }
}
