using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows= sizes[0];
            int cols= sizes[1];
            string snake = Console.ReadLine();
            char[,] matrix=new char[rows, cols];
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (counter>=snake.Length)
                    {
                        counter = 0;
                    }
                    matrix[row, col] = snake[counter];
                    counter++;
                }
            }
            int print = 0;
            for (int i = 0; i < rows; i++)
            {
                if (print%2==0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[i, col]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {
                        Console.Write(matrix[i,col]);
                    }
                    Console.WriteLine();
                }
                print++;
            }
        }
    }
}
