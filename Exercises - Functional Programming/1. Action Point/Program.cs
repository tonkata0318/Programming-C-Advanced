string[] persons = Console.ReadLine().Split(" ");
foreach (var item in persons)
{
    Action<string> print = GetPrint(item);
    print(item);
}
Action<string> GetPrint(string name)
{
    return n=> Console.WriteLine($"{name}");
}
