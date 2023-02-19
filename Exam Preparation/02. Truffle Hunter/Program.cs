using System;
using System.Linq;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            char[,] matrix=new char[n,n];
            for (int i = 0; i < n; i++)
            {
                char[] colElements = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colElements[j];
                }
            }
            string command = string.Empty;
            int counterforBlack = 0;
            int counterforWhite = 0;
            int counterforSummer = 0;
            int counttrufelsforBear = 0;
            while ((command=Console.ReadLine())!= "Stop the hunt")
            {
                string[] cmdInfo = command.Split(" ");
                string cmdType= cmdInfo[0];
                if (cmdType=="Collect")
                {
                    int rows = int.Parse(cmdInfo[1]);
                    int cols = int.Parse(cmdInfo[2]);
                    if (matrix[rows,cols]=='S')
                    {
                        matrix[rows, cols] = '-';
                        counterforSummer++;
                    }
                    else if (matrix[rows,cols]=='W')
                    {
                        matrix[rows, cols] = '-';
                        counterforWhite++;
                    }
                    else if (matrix[rows,cols]=='B')
                    {
                        matrix[rows, cols] = '-';
                        counterforBlack++;
                    }
                }
                else if (cmdType== "Wild_Boar")
                {
                    int row = int.Parse(cmdInfo[1]);
                    int cols = int.Parse(cmdInfo[2]);
                    string direction = cmdInfo[3];
                    if (direction=="up")
                    {
                        int count = 0;
                        for (int i = row; i >= 0; i--)
                        {
                            if (count%2==0)
                            {
                                if (matrix[i,cols]=='B')
                                {
                                    matrix[i, cols] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else if (matrix[i, cols] =='S')
                                {
                                    matrix[i, cols] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else if (matrix[i, cols] =='W')
                                {
                                    matrix[i, cols] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else
                                {
                                    count++;
                                }
                            }
                            else
                            {
                                count++;
                            }
                        }
                    }
                    else if (direction=="down")
                    {
                        int count = 0;
                        for (int i = row; i <= n-1; i++)
                        {
                            if (count % 2 == 0)
                            {
                                if (matrix[i, cols] == 'B')
                                {
                                    matrix[i, cols] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else if (matrix[i, cols] == 'S')
                                {
                                    matrix[i, cols] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else if (matrix[i, cols] == 'W')
                                {
                                    matrix[i, cols] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else
                                {
                                    count++;
                                }
                            }
                            else
                            {
                                count++;
                            }
                        }
                    }
                    else if (direction=="right")
                    {
                        int count = 0;
                        for (int i = cols; i <= n-1; i++)
                        {
                            if (count % 2 == 0)
                            {
                                if (matrix[row, i] == 'B')
                                {
                                    matrix[row, i] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else if (matrix[row, i] == 'S')
                                {
                                    matrix[row, i] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else if (matrix[row, i] == 'W')
                                {
                                    matrix[row, i] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else
                                {
                                    count++;
                                }
                            }
                            else
                            {
                                count++;
                            }
                        }
                    }
                    else if (direction=="left")
                    {
                        int count = 0;
                        for (int i = cols; i >= 0; i--)
                        {
                            if (count % 2 == 0)
                            {
                                if (matrix[row, i] == 'B')
                                {
                                    matrix[row, i] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else if (matrix[row, i] == 'S')
                                {
                                    matrix[row, i] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else if (matrix[row, i] == 'W')
                                {
                                    matrix[row, i] = '-';
                                    counttrufelsforBear++;
                                    count++;
                                }
                                else
                                {
                                    count++;
                                }
                            }
                            else
                            {
                                count++;
                            }
                        }
                    }
                }
                //for (int i = 0; i < n; i++)
                //{
                //    for (int j = 0; j < n; j++)
                //    {
                //        Console.Write($"{matrix[i, j]} ");
                //    }
                //    Console.WriteLine();
                //}
            }
            Console.WriteLine($"Peter manages to harvest {counterforBlack} black, {counterforSummer} summer, and {counterforWhite} white truffles.");
            Console.WriteLine($"The wild boar has eaten {counttrufelsforBear} truffles.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
