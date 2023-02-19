using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers=Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
                ;
            Func<double, double> vat = x => x * 1.20;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{vat(numbers[i]):f2}");
            }
        }
    }
}
