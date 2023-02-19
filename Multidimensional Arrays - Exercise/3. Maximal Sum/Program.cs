using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix=new int[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int MaxSum = int.MinValue;
            int curSum = 0;
            int maxrows = 0;
            int maxCols = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col<matrix.GetLength(1)-2&&row<matrix.GetLength(0)-2)
                    {
                        curSum += matrix[row, col];
                        curSum += matrix[row, col + 1];
                        curSum += matrix[row, col + 2];
                        curSum += matrix[row + 1, col];
                        curSum += matrix[row + 1, col + 1];
                        curSum += matrix[row + 1, col + 2];
                        curSum += matrix[row + 2, col];
                        curSum += matrix[row + 2, col + 1];
                        curSum+=matrix[row + 2, col + 2];
                        if (curSum > MaxSum)
                        {
                            maxrows = row;
                            maxCols = col;
                            MaxSum = curSum;
                        }
                        curSum = 0;
                    }
                }
            }
            Console.WriteLine($"Sum = {MaxSum}");
            Console.WriteLine($"{matrix[maxrows,maxCols]} {matrix[maxrows,maxCols+1]} {matrix[maxrows,maxCols+2]}");
            Console.WriteLine($"{matrix[maxrows+1, maxCols]} {matrix[maxrows+1, maxCols + 1]} {matrix[maxrows+1, maxCols + 2]}");
            Console.WriteLine($"{matrix[maxrows+2, maxCols]} {matrix[maxrows+2, maxCols + 1]} {matrix[maxrows+2, maxCols + 2]}");
        }
    }
}
