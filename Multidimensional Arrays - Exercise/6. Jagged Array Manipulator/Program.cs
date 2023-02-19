using System;
using System.Linq;
using System.Linq.Expressions;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows=int.Parse(Console.ReadLine());
            int[][] jaggedArray=new int[rows][];
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                if (row<=jaggedArray.Length-2)
                {
                    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                    {
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                        {
                            jaggedArray[row][col] *= 2;
                        }
                        for (int col = 0; col < jaggedArray[row+1].Length; col++)
                        {
                            jaggedArray[row + 1][col] *= 2;
                        }
                    }
                    else
                    {
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                        {
                            jaggedArray[row][col] /= 2;
                        }
                        for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                        {
                            jaggedArray[row + 1][col] /= 2;
                        }
                    }
                }
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] cmdInfo=command.Split(' ');
                string commandType = cmdInfo[0];
                int row = int.Parse(cmdInfo[1]);
                int col = int.Parse(cmdInfo[2]);
                int value = int.Parse(cmdInfo[3]);
                if (commandType=="Add")
                {
                    if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else if (commandType=="Subtract")
                {
                    if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
