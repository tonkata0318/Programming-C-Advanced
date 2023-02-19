using System;

namespace _02._Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int aRow = 0;
            int aCol = 0;
            for (int i = 0; i < n; i++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colElements[j];
                    if (matrix[i, j] == 'A')
                    {
                        aRow = i;
                        aCol = j;
                        matrix[i, j] = '-';
                    }
                }
            }
            bool heLeaves=false;
            int gold = 0;
            while (gold<65)
            {
                string direction=Console.ReadLine();
                if (direction=="up")
                {
                    aRow--;
                    if (aRow<0)
                    {
                        aRow++;
                        heLeaves = true;
                        break;
                    }
                }
                else if (direction=="down")
                {
                    aRow++;
                    if (aRow >=n)
                    {
                        aRow--;
                        heLeaves = true;
                        break;
                    }
                }
                else if (direction=="left")
                {
                    aCol--;
                    if (aCol < 0)
                    {
                        aCol++;
                        heLeaves = true;
                        break;
                    }
                }
                else if (direction=="right")
                {
                    aCol++;
                    if (aCol >=n)
                    {
                        aCol--;
                        heLeaves = true;
                        break;
                    }
                }
                if (matrix[aRow,aCol]=='M')
                {
                    matrix[aRow, aCol] = '-';
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i,j]=='M')
                            {
                                aRow = i;
                                aCol=j;
                                matrix[i, j] = '-';
                            }
                        }
                    }
                }
                else if (char.IsDigit(matrix[aRow,aCol]))
                {
                    int number = int.Parse(matrix[aRow,aCol].ToString());
                    gold += number;
                    matrix[aRow, aCol] = '-';
                }
            }
            if (heLeaves)
            {
                Console.WriteLine("I do not need more swords!");
                Console.WriteLine($"The king paid {gold} gold coins.");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]}");
                    }
                    Console.WriteLine();
                }
            }
            else if (gold>=65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
                Console.WriteLine($"The king paid {gold} gold coins.");
                matrix[aRow, aCol] = 'A';
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
}
