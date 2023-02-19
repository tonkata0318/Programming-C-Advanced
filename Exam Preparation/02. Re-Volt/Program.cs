using System;
using System.Linq;

namespace _02._Re_Volt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOfCommands=int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int fRow = 0;
            int fCol = 0;
            for (int i = 0; i < n; i++)
            {
                char[] colElements = Console.ReadLine().ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colElements[j];
                    if (matrix[i, j] == 'f')
                    {
                        fRow = i;
                        fCol = j;
                        matrix[i, j] = '-';
                    }
                }
            }
            bool heWin = false;
            for (int i = 0; i < countOfCommands; i++)
            {
                string directions = Console.ReadLine();
                if (directions=="up")
                {
                    fRow--;
                    if (fRow<0)
                    {
                        fRow = matrix.GetLength(0) - 1;
                    }
                    if (matrix[fRow,fCol]=='B')
                    {
                        fRow--;
                        if (fRow < 0)
                        {
                            fRow = matrix.GetLength(0) - 1;
                        }
                    }
                     if (matrix[fRow,fCol]=='T')
                    {
                        fRow++;
                    }
                     if (matrix[fRow,fCol]=='F')
                    {
                        heWin= true;
                        break;
                    }
                }
                else if (directions=="down")
                {
                    fRow++;
                    if (fRow >=matrix.GetLength(0))
                    {
                        fRow = 0;
                    }
                    if (matrix[fRow, fCol] == 'B')
                    {
                        fRow++;
                        if (fRow >= matrix.GetLength(0))
                        {
                            fRow = 0;
                        }
                    }
                     if (matrix[fRow, fCol] == 'T')
                    {
                        fRow--;
                    }
                     if (matrix[fRow, fCol] == 'F')
                    {
                        heWin = true;
                        break;
                    }
                }
                else if (directions=="left")
                {
                    fCol--;
                    if (fCol < 0)
                    {
                        fCol = matrix.GetLength(1) - 1;
                    }
                    if (matrix[fRow, fCol] == 'B')
                    {
                        fCol--;
                        if (fCol < 0)
                        {
                            fCol = matrix.GetLength(1) - 1;
                        }
                    }
                     if (matrix[fRow, fCol] == 'T')
                    {
                        fCol++;
                    }
                     if (matrix[fRow, fCol] == 'F')
                    {
                        heWin = true;
                        break;
                    }
                }
                else if (directions=="right")
                {
                    fCol++; 
                    if (fCol>=matrix.GetLength(1))
                    {
                        fCol = 0;
                    }
                    if (matrix[fRow, fCol] == 'B')
                    {
                        fCol++;
                        if (fCol >= matrix.GetLength(1))
                        {
                            fCol = 0;
                        }
                    }
                     if (matrix[fRow, fCol] == 'T')
                    {
                        fCol--;
                    }
                     if (matrix[fRow, fCol] == 'F')
                    {
                        heWin = true;
                        break;
                    }
                }
            }
            if (heWin)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            matrix[fRow, fCol] = 'f';
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
