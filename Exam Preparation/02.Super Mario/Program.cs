using System;

namespace _02.Super_Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];
            int mRow = 0;
            int mCol = 0;
            int pRow = 0;
            int pCol = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                matrix[i] = new char[colElements.Length];
                for (int j = 0; j < colElements.Length; j++)
                {
                    matrix[i][j] = colElements[j];
                    if (matrix[i][j] == 'M')
                    {
                        mRow = i;
                        mCol = j;
                        matrix[i][j] = '-';
                    }
                    else if (matrix[i][j] == 'P')
                    {
                        pRow = i;
                        pCol= j;
                    }
                }
            }
            bool isSaved = false;
            while (true)
            {
                string[] cmdInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = cmdInfo[0];
                int rows = int.Parse(cmdInfo[1]);
                int cols = int.Parse(cmdInfo[2]);
                matrix[rows][cols] = 'B';
                if (commandType == "W")
                {
                    mRow--;
                    lives--;
                    if (mRow < 0)
                    {
                        mRow++;
                        continue;
                    }
                    if (lives <= 0)
                    {
                        matrix[mRow][mCol] = 'X';
                        break;
                    }
                }
                else if (commandType == "S")
                {
                    mRow++;
                    lives--;
                    if (mRow >= n)
                    {
                        mRow--;
                        continue;
                    }
                    if (lives <= 0)
                    {
                        matrix[mRow][mCol] = 'X';
                        break;
                    }
                }
                else if (commandType == "A")
                {
                    mCol--;
                    lives--;
                    if (mCol < 0)
                    {
                        mCol++;
                        continue;
                    }
                    if (lives <= 0)
                    {
                        matrix[mRow][mCol] = 'X';
                        break;
                    }
                }
                else if (commandType == "D")
                {
                    mCol++;
                    lives--;
                    if (mCol >= matrix[mRow].Length)
                    {
                        mCol--;
                        continue;
                    }
                    if (lives <= 0)
                    {
                        matrix[mRow][mCol] = 'X';
                        break;
                    }
                }
                if (matrix[mRow][mCol] == 'B')
                {
                    lives -= 2;
                    if (lives <= 0)
                    {
                        matrix[mRow][mCol] = 'X';
                        break;
                    }
                    else
                    {
                        matrix[mRow][mCol] = '-';
                    }
                }
                else if (mRow==pRow&&mCol==pCol)
                {
                    isSaved = true;
                    break;
                }
            }
            if (isSaved)
            {
                matrix[mRow][mCol] = '-';
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else
            {
                Console.WriteLine($"Mario died at {mRow};{mCol}.");
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int cols = 0; cols < matrix[row].Length; cols++)
                {
                    Console.Write($"{matrix[row][cols]}");
                }
                Console.WriteLine();
            }
        }
    }
}
