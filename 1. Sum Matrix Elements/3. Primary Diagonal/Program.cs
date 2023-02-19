using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int sum = 0;
            int count = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = count; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                    count++;
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
