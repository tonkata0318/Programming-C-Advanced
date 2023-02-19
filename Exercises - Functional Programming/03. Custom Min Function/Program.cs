int[] numbers=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
Func<int[], int> FindSmalest = n => n.Min();
int min = FindSmalest(numbers);
Console.WriteLine(min);

