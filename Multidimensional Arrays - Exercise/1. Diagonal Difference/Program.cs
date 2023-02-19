using System;
using System.Linq;
using System.Numerics;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[,] matrtix = new int[n, n];
            for (int row = 0; row < matrtix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrtix.GetLength(1); col++)
                {
                    matrtix[row, col] = colElements[col];
                }
            }
            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;
            for (int row = 0; row < matrtix.GetLength(0); row++)
            {
                leftDiagonalSum += matrtix[row, row];
                rightDiagonalSum += matrtix[row, n - 1 - row];
            }
            Console.WriteLine($"{Math.Abs(rightDiagonalSum-leftDiagonalSum)}");
        }
    }
}
