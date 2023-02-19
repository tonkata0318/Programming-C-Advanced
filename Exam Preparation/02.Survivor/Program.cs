using System;
using System.Linq;

namespace _02.Survivor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];
            for (int i = 0; i < matrix.Length; i++)
            {
                char[] colElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                matrix[i] = new char[colElements.Length];
                for (int j = 0; j < colElements.Length; j++)
                {
                    matrix[i][j] = colElements[j];
                }
            }
            string command=string.Empty;
            int collectedTokens = 0;
            int countOponentsToken = 0;
            while ((command=Console.ReadLine())!="Gong")
            {
                string[] cmdInfo = command.Split(" ");
                string commandType = cmdInfo[0];
                if (commandType=="Find")
                {
                    int row = int.Parse(cmdInfo[1]);
                    int cols = int.Parse(cmdInfo[2]);
                    if (row<0||row>=n||cols<0||cols>=matrix[row].Length)
                    {
                        continue;
                    }
                    else
                    {
                        if (matrix[row][cols]=='T')
                        {
                            collectedTokens++;
                            matrix[row][cols] = '-';
                        }
                    }
                }
                else if (commandType=="Opponent")
                {
                    int row = int.Parse(cmdInfo[1]);
                    int cols = int.Parse(cmdInfo[2]);
                    string direction = cmdInfo[3];
                    if (row < 0 || row >= n || cols < 0 || cols >= matrix[row].Length)
                    {
                        continue;
                    }
                    else
                    {
                        if (matrix[row][cols]=='T')
                        {
                            countOponentsToken++;
                        }
                        matrix[row][cols] = '-';
                        if (direction=="up")
                        {
                            for (int i = row; i >=row-3 ; i--)
                            {
                                if (i<0)
                                {
                                    break;
                                }
                                if (matrix[i][cols]=='T')
                                {
                                    countOponentsToken++;
                                    matrix[i][cols] = '-';
                                }
                            }
                        }
                        else if (direction=="down")
                        {
                            for (int i = row; i <= row + 3; i++)
                            {
                                if (i>=n)
                                {
                                    break;
                                }
                                if (matrix[i][cols] == 'T')
                                {
                                    countOponentsToken++;
                                    matrix[i][cols] = '-';
                                }
                            }
                        }
                        else if (direction=="left")
                        {
                            for (int i = cols; i >= cols - 3; i--)
                            {
                                if (i<0)
                                {
                                    break;
                                }
                                if (matrix[row][i] == 'T')
                                {
                                    countOponentsToken++;
                                    matrix[row][i] = '-';
                                }
                            }
                        }
                        else if (direction=="right")
                        {
                            for (int i = cols; i <= cols + 3; i++)
                            {
                                if (i >= matrix[row].Length)
                                {
                                    break;
                                }
                                if (matrix[row][i] == 'T')
                                {
                                    countOponentsToken++;
                                    matrix[row][i] = '-';
                                }
                            }
                        }
                    }
                }
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int cols = 0; cols < matrix[row].Length; cols++)
                {
                    Console.Write($"{matrix[row][cols]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {countOponentsToken}");
        }
    }
}
