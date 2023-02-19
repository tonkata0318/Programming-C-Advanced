﻿namespace _4.Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> stones=Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Lake lake = new(stones);

            Console.WriteLine(string.Join(", ",lake));
        }
    }
}