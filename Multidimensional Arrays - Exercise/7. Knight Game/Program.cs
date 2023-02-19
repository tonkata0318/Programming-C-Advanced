using System;
using System.Linq;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string crrRow = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }

            int knightCount = 0;

            while (true)
            {
                bool isKnight = false;

                int maxAttack = 0;
                int macRow = 0;
                int maxCol = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {


                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                        if (matrix[row, col] == 'K')
                        {

                            int crrAttack = 0;

                            //up - left

                            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                            {
                                crrAttack++;
                            }

                            // left - up

                            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
                            {
                                crrAttack++;
                            }

                            // left - down
                            if (row + 1 < size && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
                            {
                                crrAttack++;
                            }

                            // down left

                            if (row + 2 < size && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                            {
                                crrAttack++;
                            }


                            // up - right

                            if (row - 2 >= 0 && col + 1 < size && matrix[row - 2, col + 1] == 'K')
                            {
                                crrAttack++;
                            }

                            // right up 

                            if (row - 1 >= 0 && col + 2 < size && matrix[row - 1, col + 2] == 'K')
                            {
                                crrAttack++;
                            }

                            // right - down

                            if (row + 1 < size && col + 2 < size && matrix[row + 1, col + 2] == 'K')
                            {
                                crrAttack++;
                            }

                            // down - right

                            if (row + 2 < size && col + 1 < size && matrix[row + 2, col + 1] == 'K')
                            {
                                crrAttack++;
                            }
                            if (crrAttack > maxAttack)
                            {
                                maxAttack = crrAttack;
                                macRow = row;
                                maxCol = col;
                                isKnight = true;
                            }
                        }

                    }
                }

                if (isKnight)
                {
                    matrix[macRow, maxCol] = '0';
                    knightCount++;
                }

                if (maxAttack == 0)
                {
                    break;
                }
            }

            Console.WriteLine(knightCount);

        }
    }
}