using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount=int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string,List<decimal>>();
            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (studentGrades.ContainsKey(name))
                {
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name] = new List<decimal>();
                    studentGrades[name].Add(grade);
                }
            }
            foreach (var kvp in studentGrades)
            {
                Console.Write($"{kvp.Key} -> ");
                foreach (var item in kvp.Value)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
