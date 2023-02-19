using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meals=new Queue<string>(Console.ReadLine().Split(" "));
            Stack<int> calories=new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int countforMeals = 0;
            int caloriesForDay = calories.Peek();
            while (meals.Count>0&&calories.Count>0)
            {
                if (meals.Peek()=="salad")
                {
                    int calculations = caloriesForDay- 350;
                    meals.Dequeue();
                    countforMeals++;
                    caloriesForDay -= 350;
                    if (calculations < 0)
                    {
                        calories.Pop();
                        if (calories.Count > 0)
                        {
                            caloriesForDay = calories.Peek() - Math.Abs(calculations);
                            calories.Pop();
                            calories.Push(caloriesForDay);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (calculations==0)
                    {
                        calories.Pop();
                        if (calories.Count > 0)
                        {
                            caloriesForDay = calories.Peek();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        calories.Pop();
                        calories.Push(caloriesForDay);
                    }
                }
                else if (meals.Peek() == "soup")
                {
                    int calculations = caloriesForDay - 490;
                    meals.Dequeue();
                    countforMeals++;
                    caloriesForDay -= 490;
                    if (calculations < 0)
                    {
                        calories.Pop();
                        if (calories.Count > 0)
                        {
                            caloriesForDay = calories.Peek() - Math.Abs(calculations);
                            calories.Pop();
                            calories.Push(caloriesForDay);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (calculations == 0)
                    {
                        calories.Pop();
                        if (calories.Count > 0)
                        {
                            caloriesForDay = calories.Peek();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        calories.Pop();
                        calories.Push(caloriesForDay);
                    }
                }
                else if (meals.Peek() == "pasta")
                {
                    int calculations = caloriesForDay - 680;
                    meals.Dequeue();
                    countforMeals++;
                    caloriesForDay -= 680;
                    if (calculations < 0)
                    {
                        calories.Pop();
                        if (calories.Count > 0)
                        {
                            caloriesForDay = calories.Peek() - Math.Abs(calculations);
                            calories.Pop();
                            calories.Push(caloriesForDay);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (calculations == 0)
                    {
                        calories.Pop();
                        if (calories.Count > 0)
                        {
                            caloriesForDay = calories.Peek();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        calories.Pop();
                        calories.Push(caloriesForDay);
                    }
                }
                else if (meals.Peek() == "steak")
                {
                    int calculations = caloriesForDay - 790;
                    meals.Dequeue();
                    countforMeals++;
                    caloriesForDay -= 790;
                    if (calculations < 0)
                    {
                        calories.Pop();
                        if (calories.Count > 0)
                        {

                            caloriesForDay = calories.Peek() - Math.Abs(calculations);
                            calories.Pop();
                            calories.Push(caloriesForDay);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (calculations == 0)
                    {
                        calories.Pop();
                        if (calories.Count > 0)
                        {
                            caloriesForDay = calories.Peek();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        calories.Pop();
                        calories.Push(caloriesForDay);
                    }
                }
            }
            if (meals.Count==0)
            {
                Console.WriteLine($"John had {countforMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ",calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {countforMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ",meals)}.");
            }
        }
    }
}
