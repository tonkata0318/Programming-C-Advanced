List<int> numbers=Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int n=int.Parse(Console.ReadLine());
Func<List<int>, List<int>> reverse = GetReverse(numbers);
Func<List<int>,List<int>> GetReverse(List<int> numbers)
{
    numbers.Reverse();
    return n => numbers;
}
reverse(numbers);
Func<List<int>, int, List<int>> getCheckForDivide =GetChecked(numbers, n);
getCheckForDivide(numbers, n);
Func<List<int>,int,List<int>> GetChecked(List<int> numbers, int n)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] %n==0)
        {
            numbers.Remove(numbers[i]);
            i--;
        }
    }
    return (p,k) => numbers;
}
Console.WriteLine(string.Join(" ",numbers));