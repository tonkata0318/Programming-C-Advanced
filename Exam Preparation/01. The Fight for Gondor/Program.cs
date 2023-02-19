using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Fight_for_Gondor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            Queue<int> plates= new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> orcs = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            bool isAtackDefend = false;
            int counter = 0;
            for (int i = 0; i < waves; i++)
            {
                if (plates.Count > 0)
                {
                    
                    if (orcs.Count==0)
                    {
                        Stack<int> nextWave = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
                        orcs = nextWave;
                    }
                    while (orcs.Count>0&&plates.Count>0)
                    {
                        int currentorc = orcs.Peek();
                        int currentPlate = plates.Peek();
                        if (currentorc > currentPlate)
                        {
                            int orcvalueAfterAtack = currentorc - currentPlate;
                            plates.Dequeue();
                            orcs.Pop();
                            orcs.Push(orcvalueAfterAtack);
                        }
                        else if (currentPlate > currentorc)
                        {
                            int decreasevaluOfPlaye = currentPlate - currentorc;
                            orcs.Pop();
                            plates.Dequeue();
                            plates.Enqueue(decreasevaluOfPlaye);
                            for (int j = 1; j < plates.Count; j++)
                            {
                                int value = plates.Dequeue();
                                plates.Enqueue(value);
                            }
                        }
                        else if (currentPlate==currentorc)
                        {
                            orcs.Pop();
                            plates.Dequeue();
                        }
                    }
                    counter++;
                    if (counter%3==0)
                    {
                        Queue<int> stack = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
                        foreach (var item in stack)
                        {
                            plates.Enqueue(item);
                        }
                    }
                }
                else
                {
                    isAtackDefend= true;
                    break;
                }
            }
            if (isAtackDefend)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }
            if (plates.Count>0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ",plates)}");
            }
            if (orcs.Count>0)
            {
                Console.WriteLine($"Orcs left: {string.Join(", ",orcs)}");
            }
        }
    }
}
