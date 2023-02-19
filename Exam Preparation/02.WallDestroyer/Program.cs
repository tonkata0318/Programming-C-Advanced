using System;

namespace _02.WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int vRow = 0;
            int vCol = 0;
            for (int i = 0; i < n; i++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colElements[j];
                    if (matrix[i, j] == 'V')
                    {
                        vRow = i;
                        vCol = j;
                    }
                }
            }
            string command=string.Empty;
            int counterForHoles = 1;
            int counterforRoads = 0;
            bool isElectrocuted=false;
            while ((command=Console.ReadLine())!="End")
            {
                if (matrix[vRow,vCol]=='R')
                {

                }
                else
                {
                    matrix[vRow, vCol] = '*';
                }
                if (command=="right")
                {
                    if (vCol+1>=n)
                    {
                        continue;
                    }
                    else
                    {
                        vCol++;
                    }
                    if (matrix[vRow, vCol] == '-')
                    {
                        counterForHoles++;
                    }
                    else if (matrix[vRow, vCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        counterforRoads++;
                        vCol--;
                        continue;
                    }
                    else if (matrix[vRow, vCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol}]!");
                        continue;
                    }
                    else if (matrix[vRow, vCol] == 'C')
                    {
                        isElectrocuted = true;
                        matrix[vRow, vCol] = 'E';
                        counterForHoles++;
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {counterForHoles} hole(s).");
                        break;
                    }
                }
                else if (command=="left")
                {
                    if (vCol - 1< 0)
                    {
                        continue;
                    }
                    else
                    {
                        vCol--;
                    }
                    if (matrix[vRow, vCol] == '-')
                    {
                        counterForHoles++;
                    }
                    else if (matrix[vRow, vCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        counterforRoads++;
                        vCol++;
                        continue;
                    }
                    else if (matrix[vRow, vCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol}]!");
                        continue;
                    }
                    else if (matrix[vRow, vCol] == 'C')
                    {
                        isElectrocuted = true;
                        matrix[vRow, vCol] = 'E';
                        counterForHoles++;
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {counterForHoles} hole(s).");
                        break;
                    }
                }
                else if (command=="up")
                {
                    if (vRow - 1 < 0)
                    {
                        continue;
                    }
                    else
                    {
                        vRow--;
                    }
                    if (matrix[vRow, vCol] == '-')
                    {
                        counterForHoles++;
                    }
                    else if (matrix[vRow, vCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        counterforRoads++;
                        vRow++;
                        continue;
                    }
                    else if (matrix[vRow, vCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol}]!");
                        continue;
                    }
                    else if (matrix[vRow, vCol] == 'C')
                    {
                        isElectrocuted = true;
                        matrix[vRow, vCol] = 'E';
                        counterForHoles++;
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {counterForHoles} hole(s).");
                        break;
                    }
                }
                else if (command=="down")
                {
                    if (vRow + 1 >=n)
                    {
                        continue;
                    }
                    else
                    {
                        vRow++;
                    }
                    if (matrix[vRow, vCol] == '-')
                    {
                        counterForHoles++;
                    }
                    else if (matrix[vRow, vCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        counterforRoads++;
                        vRow--;
                        continue;
                    }
                    else if (matrix[vRow, vCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vRow}, {vCol}]!");
                        continue;
                    }
                    else if (matrix[vRow, vCol] == 'C')
                    {
                        isElectrocuted = true;
                        matrix[vRow, vCol] = 'E';
                        counterForHoles++;
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {counterForHoles} hole(s).");
                        break;
                    }
                }
                
            }
            if (isElectrocuted==false)
            {
                matrix[vRow, vCol] = 'V';
                Console.WriteLine($"Vanko managed to make {counterForHoles} hole(s) and he hit only {counterforRoads} rod(s).");
            }
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
