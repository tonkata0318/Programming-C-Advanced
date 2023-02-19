Queue<int> textile = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
Dictionary<string, int> suplies = new Dictionary<string, int>();
while (textile.Count>0&&medicaments.Count>0)
{
    int sum = textile.Peek() + medicaments.Peek();
	if (sum==30)
	{
		if (!suplies.ContainsKey("Patch"))
		{
			suplies["Patch"] = 1;
		}
		else
		{
			suplies["Patch"]++;
		}
        textile.Dequeue();
        medicaments.Pop();
	}
	else if (sum == 40)
    {
        if (!suplies.ContainsKey("Bandage"))
        {
            suplies["Bandage"] = 1;
        }
        else
        {
            suplies["Bandage"]++;
        }
        textile.Dequeue();
        medicaments.Pop();
    }
    else if (sum == 100)
    {
        if (!suplies.ContainsKey("MedKit"))
        {
            suplies["MedKit"] = 1;
        }
        else
        {
            suplies["MedKit"]++;
        }
        textile.Dequeue();
        medicaments.Pop();
    }
    else if (sum>100)
    {
        if (!suplies.ContainsKey("MedKit"))
        {
            suplies["MedKit"] = 1;
        }
        else
        {
            suplies["MedKit"]++;
        }
        textile.Dequeue();
        medicaments.Pop();
        int remaining = medicaments.Peek()+(sum - 100);
        medicaments.Pop();
        medicaments.Push(remaining);
    }
    else
    {
        int getBack = medicaments.Peek() + 10;
        textile.Dequeue();
        medicaments.Pop();
        medicaments.Push(getBack);
    }
}
if (medicaments.Count == 0 && textile.Count == 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (textile.Count==0)
{
    Console.WriteLine("Textiles are empty.");
}
else if (medicaments.Count==0)
{
    Console.WriteLine("Medicaments are empty.");
}
foreach (var item in suplies.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
if (medicaments.Count>0)
{
    Console.WriteLine($"Medicaments left: {string.Join(", ",medicaments)}");
}
if (textile.Count>0)
{
    Console.WriteLine($"Textiles left: {string.Join(", ",textile)}");
}