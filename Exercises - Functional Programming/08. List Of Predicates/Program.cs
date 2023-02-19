int n=int.Parse(Console.ReadLine());
int[] sequnces = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Func<int[], int, List<int>> getNums = GetNumbers(sequnces, n);
Func<int[],int,List<int>> GetNumbers(int[] ints, int n)
{
    int[] numbers = new int[n];
	List<int> list = new List<int>();
	for (int i = 0; i < numbers.Length; i++)
	{
		numbers[i] = i+1;
	}
	bool numberPass = false;
	for (int i = 0; i < numbers.Length; i++)
	{
		foreach (var item in ints)
		{
			if (numbers[i]%item==0)
			{
				numberPass= true;
			}
			else
			{
				numberPass= false;
				break;
			}
		}
		if (numberPass==true)
		{
			list.Add(numbers[i]);
		}
	}
	return (p, t) => list;
}
List<int> ints=getNums(sequnces, n);
Console.WriteLine(string.Join(" ",ints));
