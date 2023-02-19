int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int start = input[0];
int end = input[1];
string evenOrOdd = Console.ReadLine();
Predicate<int> predicateforEven = n => n % 2 == 0;
Predicate<int> predicateForOdd=n => n % 2 != 0;
for (int i = start; i <= end; i++)
{
	if (evenOrOdd=="even")
	{
		if (predicateforEven(i))
		{
			Console.Write(i+" ");
		}
	}
	else if (evenOrOdd=="odd")
	{
		if (predicateForOdd(i))
		{
			Console.Write(i+" ");
		}
	}
}
