using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            char[,] matrix=new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] colElemets = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElemets[col];
                }
            }
            int count = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col<cols-1&&row<rows-1)
                    {
                        char currSymbol = matrix[row, col];
                        if (matrix[row, col + 1] == currSymbol && matrix[row + 1, col] == currSymbol && matrix[row + 1, col + 1] == currSymbol)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
