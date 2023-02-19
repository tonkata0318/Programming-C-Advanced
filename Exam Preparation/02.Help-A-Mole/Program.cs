using System;
using System.Linq;

namespace _02.Help_A_Mole
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix=new char[n,n];
            int mRow = 0;
            int mCol = 0;
            for (int i = 0; i < n; i++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colElements[j];
                    if (matrix[i,j]=='M')
                    {
                        mRow = i;
                        mCol=j;
                    }
                }
            }
            string direction = string.Empty;
            int points = 0;
            bool survived=false;
            bool endCicle = false;
            while ((direction=Console.ReadLine())!="End")
            {
                matrix[mRow, mCol] = '-';
                if (direction == "left")
                {
                    if (mCol - 1 < 0)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    else
                    {
                        mCol = mCol - 1;
                    }
                }
                else if (direction == "right")
                {
                    if (mCol + 1 >= n)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    else
                    {
                        mCol = mCol + 1;
                    }
                }
                else if (direction == "down")
                {
                    if (mRow + 1 >= n)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    else
                    {
                        mRow = mRow + 1;
                    }
                }
                else if (direction == "up")
                {
                    if (mRow - 1 < 0)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    else
                    {
                        mRow = mRow - 1;
                    }
                }
                if (char.IsDigit(matrix[mRow,mCol]))
                {
                    points += int.Parse(matrix[mRow, mCol].ToString());
                }
                else if (matrix[mRow,mCol]=='S')
                {
                    matrix[mRow, mCol] = '-';
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (matrix[i,j]=='S')
                            {
                                mRow = i;
                                mCol = j;
                                points -= 3;
                                matrix[i, j] = '-';
                                endCicle = true;
                                break;
                            }
                        }
                        if (endCicle==true)
                        {
                            break;
                        }
                    }
                }
                if (points>=25)
                {
                    survived = true;
                    break;
                }
            }
            if (survived)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }
            matrix[mRow, mCol] = 'M';
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
