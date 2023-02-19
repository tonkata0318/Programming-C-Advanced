
int n=int.Parse(Console.ReadLine());
List<Person> list=new List<Person>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    string name = input[0];
    int age = int.Parse(input[1]);
    list.Add(new Person() {Name=name,Age=age});
}
string FilterType=Console.ReadLine();
int value=int.Parse(Console.ReadLine());

Func<Person, int, bool> filter = GetFilter(FilterType);
list=list.Where(p=>filter(p,value)).ToList();
Action<Person> formater=GetFormat(Console.ReadLine());
foreach (var person in list)
{
    formater(person);
}
Func<Person, int, bool> GetFilter(string FilterType)
{
    if (FilterType=="younger")
    {
        return (Person p,int value) => p.Age < value;
    }
    else
    {
        return (Person p,int value) => p.Age >= value;
    }
}
Action<Person> GetFormat(string formatType)
{
    if (formatType=="name age")
    {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    else if (formatType=="age")
    {
        return p => Console.WriteLine($"{p.Age}");
    }
    else if (formatType=="name")
    {
        return p => Console.WriteLine($"{p.Name}");
    }
    return null;
}
class Person
{
    public string Name;
    public int Age;
}
