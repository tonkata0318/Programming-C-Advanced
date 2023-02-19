using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BeaveratWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int bRow = 0;
            int bCol = 0;
            int countofAllBranches = 0;
            for (int i = 0; i < n; i++)
            {
                string[] colElements = Console.ReadLine().Split(" ").ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = char.Parse(colElements[j]);
                    if (matrix[i, j] == 'B')
                    {
                        bRow = i;
                        bCol = j;
                    }
                    else if (char.IsLower(matrix[i, j]))
                    {
                        countofAllBranches++;
                    }
                }
            }
            string command = string.Empty;
            Stack<char> branches = new Stack<char>();
            bool allCollected = false;
            int dropedBracnhesButStillOnBoard = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                matrix[bRow, bCol] = '-';
                if (command == "up")
                {
                    bRow--;
                    if (bRow < 0)
                    {
                        bRow++;
                        if (branches.Count > 0)
                        {
                            branches.Pop();
                            dropedBracnhesButStillOnBoard++;
                            continue;
                        }
                    }
                    else if (matrix[bRow, bCol] == 'F')
                    {
                        if (bRow == 0 || bCol == 0)
                        {
                            matrix[bRow, bCol] = '-';
                            bRow = n - 1;
                            if (char.IsLower(matrix[bRow, bCol]))
                            {
                                branches.Push(matrix[bRow, bCol]);
                                if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                                    allCollected = true;
                                    break;
                                }
                            }
                            matrix[bRow, bCol] = '-';
                        }
                        else
                        {
                            matrix[bRow, bCol] = '-';
                            bRow = 0;
                            if (char.IsLower(matrix[bRow, bCol]))
                            {
                                branches.Push(matrix[bRow, bCol]);
                                if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                                    allCollected = true;
                                    break;
                                }
                            }
                            matrix[bRow, bCol] = '-';
                        }
                    }
                    else if (char.IsLower(matrix[bRow, bCol]))
                    {
                        branches.Push(matrix[bRow, bCol]);
                        if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                        {
                            Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                            allCollected = true;
                            break;
                        }
                    }
                }
                else if (command == "down")
                {
                    bRow++;
                    if (bRow >= n)
                    {
                        bRow--;
                        if (branches.Count > 0)
                        {
                            branches.Pop();
                            dropedBracnhesButStillOnBoard++;
                            continue;
                        }
                        continue;
                    }
                    else if (matrix[bRow, bCol] == 'F')
                    {
                        if (bRow == 0 || bCol == 0)
                        {
                            matrix[bRow, bCol] = '-';
                            bRow = 0;
                            if (char.IsLower(matrix[bRow, bCol]))
                            {
                                branches.Push(matrix[bRow, bCol]);
                                if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                                    allCollected = true;
                                    break;
                                }
                            }
                            matrix[bRow, bCol] = '-';
                        }
                        else
                        {
                            matrix[bRow, bCol] = '-';
                            bRow = n - 1;
                            if (char.IsLower(matrix[bRow, bCol]))
                            {
                                branches.Push(matrix[bRow, bCol]);
                                if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                                    allCollected = true;
                                    break;
                                }
                            }
                            matrix[bRow, bCol] = '-';
                        }
                    }
                    else if (char.IsLower(matrix[bRow, bCol]))
                    {
                        branches.Push(matrix[bRow, bCol]);
                        if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                        {
                            Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                            allCollected = true;
                            break;
                        }
                    }
                }
                else if (command == "left")
                {
                    bCol--;
                    if (bCol < 0)
                    {
                        bCol++;
                        if (branches.Count > 0)
                        {
                            branches.Pop();
                            dropedBracnhesButStillOnBoard++;
                            continue;
                        }
                        continue;
                    }
                    else if (matrix[bRow, bCol] == 'F')
                    {
                        if (bRow == 0 || bCol == 0)
                        {
                            matrix[bRow, bCol] = '-';
                            bCol = n - 1;
                            if (char.IsLower(matrix[bRow, bCol]))
                            {
                                branches.Push(matrix[bRow, bCol]);
                                if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                                    allCollected = true;
                                    break;
                                }
                            }
                            matrix[bRow, bCol] = '-';

                        }
                        else
                        {
                            matrix[bRow, bCol] = '-';
                            bCol = 0;
                            if (char.IsLower(matrix[bRow, bCol]))
                            {
                                branches.Push(matrix[bRow, bCol]);
                                if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                                    allCollected = true;
                                    break;
                                }
                            }
                            matrix[bRow, bCol] = '-';
                        }
                    }
                    else if (char.IsLower(matrix[bRow, bCol]))
                    {
                        branches.Push(matrix[bRow, bCol]);
                        if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                        {
                            Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches).Reverse()}.");
                            allCollected = true;
                            break;
                        }
                    }
                }
                else if (command == "right")
                {
                    bCol++;
                    if (bCol >= n)
                    {
                        bCol--;
                        if (branches.Count > 0)
                        {
                            branches.Pop();
                            dropedBracnhesButStillOnBoard++;
                            continue;
                        }
                        continue;
                    }
                    else if (matrix[bRow, bCol] == 'F')
                    {
                        matrix[bRow, bCol] = '-';
                        if (bRow == 0 || bCol == 0)
                        {
                            bCol = 0;
                            if (char.IsLower(matrix[bRow, bCol]))
                            {
                                branches.Push(matrix[bRow, bCol]);
                                if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                                    allCollected = true;
                                    break;
                                }
                            }
                            matrix[bRow, bCol] = '-';
                        }
                        else
                        {
                            matrix[bRow, bCol] = '-';
                            bCol = n - 1;
                            if (char.IsLower(matrix[bRow, bCol]))
                            {
                                branches.Push(matrix[bRow, bCol]);
                                if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                                    allCollected = true;
                                    break;
                                }
                            }
                            matrix[bRow, bCol] = '-';

                        }
                    }
                    else if (char.IsLower(matrix[bRow, bCol]))
                    {
                        branches.Push(matrix[bRow, bCol]);
                        if ((branches.Count + dropedBracnhesButStillOnBoard) == countofAllBranches)
                        {
                            Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
                            allCollected = true;
                            break;
                        }
                    }
                }
                }
                if (allCollected == false)
                {
                    Console.WriteLine($"The Beaver failed to collect every wood branch. There are {countofAllBranches - (branches.Count + dropedBracnhesButStillOnBoard)} branches left.");
                }
                matrix[bRow, bCol] = 'B';
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
