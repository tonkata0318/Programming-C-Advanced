using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows=int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row]=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }
            string command = Console.ReadLine();
            while (command!="END")
            {
                string[] cmdInfo = command.Split(" ");
                string commandType = cmdInfo[0];
                int row = int.Parse(cmdInfo[1]);
                int col = int.Parse(cmdInfo[2]);
                int value = int.Parse(cmdInfo[3]);
                if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command=Console.ReadLine();
                    continue;
                }
                else
                {
                    if (commandType=="Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                command=Console.ReadLine();
            }
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
