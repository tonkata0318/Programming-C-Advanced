
int n=int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine().Split(" ").ToList();
Func<List<string>,int,List<string>> findnamesWithLentghN=GetNames(names,n);
Func<List<string>,int,List<string>> GetNames(List<string> names,int n)
{
	for (int i = 0; i < names.Count; i++)
	{
		if (names[i].Length>n)
		{
			names.Remove(names[i]);
			i--;
		}
	}
	return (p, t) => names;
}
findnamesWithLentghN(names,n);
foreach (var name in names)
{
	Console.WriteLine(name);
}