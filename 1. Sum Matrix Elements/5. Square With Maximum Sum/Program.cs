using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix=new int[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col]= colElements[col];
                }
            }
            int bigeestSum = 0;
            int biggestrow = 0;
            int biggestcol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentSum = 0;
                    if (col<matrix.GetLength(1)-1&&row<matrix.GetLength(0)-1)
                    {
                        currentSum += matrix[row, col];
                        currentSum += matrix[row, col + 1];
                        currentSum += matrix[row + 1, col];
                        currentSum += matrix[row + 1, col + 1];
                        if (currentSum > bigeestSum)
                        {
                            bigeestSum = currentSum;
                            biggestrow=row;
                            biggestcol=col;
                        }
                    }
                   
                }
            }
            Console.WriteLine($"{matrix[biggestrow,biggestcol]} {matrix[biggestrow,biggestcol+1]}");
            Console.WriteLine($"{matrix[biggestrow+1, biggestcol]} {matrix[biggestrow+1, biggestcol + 1]}");
            Console.WriteLine(bigeestSum);
        }
    }
}
