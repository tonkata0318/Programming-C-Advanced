using System;
using System.Data;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            string comman= Console.ReadLine();
            while (comman!="END")
            {
                string[] cmdInfo=comman.Split(" ");
                if (cmdInfo.Length == 5)
                {
                    string typeOfCommand = cmdInfo[0];
                    int row1 = int.Parse(cmdInfo[1]);
                    int col1 = int.Parse(cmdInfo[2]);
                    int row2 = int.Parse(cmdInfo[3]);
                    int col2 = int.Parse(cmdInfo[4]);
                    if (typeOfCommand != "swap" || row1 >= matrix.GetLength(0) || col1 >= matrix.GetLength(1) || row2 >= matrix.GetLength(0) || col2 >= matrix.GetLength(1) || row1 < 0 || col1 < 0 || row2 < 0 || col2 < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string temporary = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temporary;
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
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                comman = Console.ReadLine();
            }

        }
    }
}
