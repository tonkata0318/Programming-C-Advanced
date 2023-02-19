string[] names = Console.ReadLine().Split(" ");
foreach (string name in names)
{
    Action<string> print = GetPrint(name);
    print(name);
}
Action<string> GetPrint(string name)
{
    return n => Console.WriteLine($"Sir {name}");
}