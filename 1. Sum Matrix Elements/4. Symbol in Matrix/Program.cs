using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix= new char[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input= Console.ReadLine();
                char[] colElemets=input.ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = colElemets[col];
                }
            }
            char symbo=Char.Parse(Console.ReadLine());
            bool isFound = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col]==symbo)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound==true)
                {
                    break;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{symbo} does not occur in the matrix");
            }

        }
    }
}
