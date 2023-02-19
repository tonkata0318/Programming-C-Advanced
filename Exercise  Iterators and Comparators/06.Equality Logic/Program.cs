using _06.EqualityLogic;
using System;

HashSet<Person> hashset = new();
SortedSet<Person> sortedste = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] personProps = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    Person person = new()
    { 
        Name= personProps[0],
        Age= int.Parse(personProps[1])
    };
    hashset.Add(person);
    sortedste.Add(person);

}

Console.WriteLine(hashset.Count);
Console.WriteLine(sortedste.Count);