using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long rows=long.Parse(Console.ReadLine());
            if (rows == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                long[][] pascal = new long[rows][];
                pascal[0] = new long[1] { 1 };
                pascal[1] = new long[2] { 1, 1 };
                for (int row = 2; row < pascal.Length; row++)
                {
                    pascal[row] = new long[row + 1];
                    for (int col = 0; col < pascal[row].Length; col++)
                    {
                        if (col == 0)
                        {
                            pascal[row][col] = pascal[row - 1][col];
                        }
                        else if (col == row)
                        {
                            pascal[row][col] = pascal[row - 1][col - 1];
                        }
                        else
                        {
                            pascal[row][col] = pascal[row - 1][col] + pascal[row - 1][col - 1];
                        }
                    }
                }
                for (int row = 0; row < pascal.Length; row++)
                {
                    for (int col = 0; col < pascal[row].Length; col++)
                    {
                        Console.Write($"{pascal[row][col]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
