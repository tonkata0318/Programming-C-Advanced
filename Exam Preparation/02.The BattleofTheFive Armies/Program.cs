using System;
using System.Linq;

namespace _02.The_BattleofTheFive_Armies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int n=int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];
            int aRow = 0;
            int aCol = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                matrix[i]=new char[colElements.Length];
                for (int j = 0; j < colElements.Length ; j++)
                {
                    matrix[i][j] = colElements[j];
                    if (matrix[i][j] == 'A')
                    {
                        aRow = i;
                        aCol = j;
                        matrix[i][j] = '-';
                    }
                }
            }
            bool areTheyDead = false;
            while (true)
            {
                string[] cmdInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string direction = cmdInfo[0];
                int rows = int.Parse(cmdInfo[1]);
                int cols= int.Parse(cmdInfo[2]);
                matrix[aRow][aCol] = '-';
                matrix[rows][cols] = 'O';
                if (direction=="up")
                {
                    aRow--;
                    armor--;
                    if (aRow<0)
                    {
                        aRow++;
                        continue;
                    }
                }
                else if (direction == "down")
                {
                    aRow++;
                    armor--;
                    if (aRow>=n)
                    {
                        aRow--;
                        continue;
                    }
                }
                else if (direction == "left")
                {
                    aCol--;
                    armor--;
                    if (aCol < 0)
                    {
                        aCol++;
                        continue;
                    }
                }
                else if (direction == "right")
                {
                    aCol++;
                    armor--;
                    if (aCol >= matrix[aRow].Length)
                    {
                        aCol--;
                        continue;
                    }
                }
                if (matrix[aRow][aCol] == 'O')
                {
                    armor -= 2;
                    if (armor<=0)
                    {
                        areTheyDead = true;
                        matrix[aRow][aCol] = 'X';
                        break;
                    }
                    else
                    {
                        matrix[aRow][aCol] = '-';
                    }
                }
                else if (matrix[aRow][aCol] == 'M')
                {
                    matrix[aRow][aCol] = '-';
                    break;
                }
            }

            if (areTheyDead)
            {
                Console.WriteLine($"The army was defeated at {aRow};{aCol}.");
            }
            else
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int cols = 0; cols < matrix[row].Length; cols++)
                {
                    if (matrix[row][cols] == '?' && areTheyDead == true)
                    {
                        matrix[row][cols] = 'M';
                        Console.Write($"{matrix[row][cols]}");
                    }
                    else
                    {
                        Console.Write($"{matrix[row][cols]}");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
