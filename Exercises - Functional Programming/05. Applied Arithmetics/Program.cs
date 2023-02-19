List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string command=Console.ReadLine();
while (command!="end")
{
    if (command=="add")
    {
        Func<List<int>, List<int>> add = GetAdd(numbers);
        add(numbers);
    }
    else if (command=="multiply")
    {
        Func<List<int>, List<int>> multiply = GetMultiply(numbers);
        multiply(numbers);
    }
    else if (command== "subtract")
    {
        Func<List<int>, List<int>> substract = GetSubstract(numbers);
        substract(numbers);
    }
    else if (command=="print")
    {
        Action<List<int>> print = GetPrint(numbers);
        print(numbers);
    }
    command = Console.ReadLine();
}
Func<List<int>, List<int>> GetAdd(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i]++;
    }
    return n=>numbers;
}
Func<List<int>,List<int>> GetMultiply(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i]=numbers[i]*2;
    }
    return n => numbers;
}
Func<List<int>,List<int>> GetSubstract(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i]--;
    }
    return n => numbers;
}
Action<List<int>> GetPrint(List<int> numbers)
{
    return n => Console.WriteLine(String.Join(" ", numbers));
}