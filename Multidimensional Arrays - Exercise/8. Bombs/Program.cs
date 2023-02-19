using System;
using System.Linq;
using System.Linq.Expressions;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine());
            int[,] matrix=new int[size,size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elementCol = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = elementCol[col];
                }
            }
            ////////////////////////////////////////////////////
            string[] bombs = Console.ReadLine().Split(" ");
            foreach (var bomb in bombs)
            {
                string[] bombInfo = bomb.Split(",");
                int bombROw = int.Parse(bombInfo[0]);
                int bombCol = int.Parse(bombInfo[1]);
                int bombValue = matrix[bombROw, bombCol];
                if (bombValue > 0)
                {
                    if (bombROw < size - 1 && bombCol > 0 && bombCol < size - 1 && bombROw > 0)
                    {
                        if (matrix[bombROw - 1, bombCol - 1] > 0)
                        {
                            matrix[bombROw - 1, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw - 1, bombCol] > 0)
                        {
                            matrix[bombROw - 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw - 1, bombCol + 1] > 0)
                        {
                            matrix[bombROw - 1, bombCol + 1] -= bombValue;
                        }
                        if (matrix[bombROw, bombCol - 1] > 0)
                        {
                            matrix[bombROw, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol - 1] > 0)
                        {
                            matrix[bombROw + 1, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol] > 0)
                        {
                            matrix[bombROw + 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol + 1] > 0)
                        {
                            matrix[bombROw + 1, bombCol + 1] -= bombValue;
                        }
                        if (matrix[bombROw, bombCol + 1] > 0)
                        {
                            matrix[bombROw, bombCol + 1] -= bombValue;
                        }
                    }
                    else if (bombROw <= size - 2 && bombCol == 0 && bombROw > 0)
                    {
                        if (matrix[bombROw + 1, bombCol] > 0)
                        {
                            matrix[bombROw + 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw, bombCol + 1] > 0)
                        {
                            matrix[bombROw, bombCol + 1] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol + 1] > 0)
                        {
                            matrix[bombROw + 1, bombCol + 1] -= bombValue;
                        }
                        if (matrix[bombROw - 1, bombCol] > 0)
                        {
                            matrix[bombROw - 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw - 1, bombCol + 1] > 0)
                        {
                            matrix[bombROw - 1, bombCol + 1] -= bombValue;
                        }
                    }
                    else if (bombROw == 0 && bombCol == 0)
                    {
                        if (matrix[bombROw, bombCol + 1] > 0)
                        {
                            matrix[bombROw, bombCol + 1] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol] > 0)
                        {
                            matrix[bombROw + 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol + 1] > 0)
                        {
                            matrix[bombROw + 1, bombCol + 1] -= bombValue;
                        }
                    }
                    else if (bombROw == 0 && bombCol == size - 1)
                    {
                        if (matrix[bombROw, bombCol - 1] > 0)
                        {
                            matrix[bombROw, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol] > 0)
                        {
                            matrix[bombROw + 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol - 1] > 0)
                        {
                            matrix[bombROw + 1, bombCol - 1] -= bombValue;
                        }
                    }
                    else if (bombROw <= size - 2 && bombCol == size - 1)
                    {
                        if (matrix[bombROw - 1, bombCol] > 0)
                        {
                            matrix[bombROw - 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw - 1, bombCol - 1] > 0)
                        {
                            matrix[bombROw - 1, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw, bombCol - 1] > 0)
                        {
                            matrix[bombROw, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol - 1] > 0)
                        {
                            matrix[bombROw + 1, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol] > 0)
                        {
                            matrix[bombROw + 1, bombCol] -= bombValue;
                        }
                    }
                    else if (bombROw == size - 1 && bombCol == 0)
                    {
                        if (matrix[bombROw - 1, bombCol] > 0)
                        {
                            matrix[bombROw - 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw - 1, bombCol + 1] > 0)
                        {
                            matrix[bombROw - 1, bombCol + 1] -= bombValue;
                        }
                        if (matrix[bombROw, bombCol + 1] > 0)
                        {
                            matrix[bombROw, bombCol + 1] -= bombValue;
                        }
                    }
                    else if (bombROw == size - 1 && bombCol == size - 1)
                    {
                        if (matrix[bombROw - 1, bombCol] > 0)
                        {
                            matrix[bombROw - 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw - 1, bombCol - 1] > 0)
                        {
                            matrix[bombROw - 1, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw, bombCol - 1] > 0)
                        {
                            matrix[bombROw, bombCol - 1] -= bombValue;
                        }
                    }
                    else if (bombROw == size - 1 && bombCol > 0 && bombCol <= size - 2)
                    {
                        if (matrix[bombROw - 1, bombCol] > 0)
                        {
                            matrix[bombROw - 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw - 1, bombCol - 1] > 0)
                        {
                            matrix[bombROw - 1, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw, bombCol - 1] > 0)
                        {
                            matrix[bombROw, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw - 1, bombCol + 1] > 0)
                        {
                            matrix[bombROw - 1, bombCol + 1] -= bombValue;
                        }
                        if (matrix[bombROw, bombCol + 1] > 0)
                        {
                            matrix[bombROw, bombCol + 1] -= bombValue;
                        }
                    }
                    else if (bombROw == 0 && bombCol > 0 && bombCol <= size - 2)
                    {
                        if (matrix[bombROw, bombCol - 1] > 0)
                        {
                            matrix[bombROw, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol - 1] > 0)
                        {
                            matrix[bombROw + 1, bombCol - 1] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol] > 0)
                        {
                            matrix[bombROw + 1, bombCol] -= bombValue;
                        }
                        if (matrix[bombROw + 1, bombCol + 1] > 0)
                        {
                            matrix[bombROw + 1, bombCol + 1] -= bombValue;
                        }
                        if (matrix[bombROw, bombCol + 1] > 0)
                        {
                            matrix[bombROw, bombCol + 1] -= bombValue;
                        }
                    }
                    matrix[bombROw, bombCol] = 0;
                }
            }
            int aliveCell = 0;
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCell++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCell}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
