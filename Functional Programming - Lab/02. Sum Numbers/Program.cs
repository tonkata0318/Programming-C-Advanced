using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Func<string, int> parser = x => int.Parse(x);
            int[] number = input
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();
            Console.WriteLine(number.Length);
            Console.WriteLine(number.Sum());
        }
    }
}

