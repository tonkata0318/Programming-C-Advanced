using System;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<char> startWithUpper = x => char.IsUpper(x);
            string[] input=Console.ReadLine().Split(" ");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > 0)
                {
                    if (startWithUpper(input[i][0]))
                    {
                        Console.WriteLine(input[i]);
                    }
                }
            }
        }
    }
}
