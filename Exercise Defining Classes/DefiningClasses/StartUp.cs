namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Family family = new Family();
            family.People = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                string name = info[0];
                int age = int.Parse(info[1]);
                Person person = new(name,age);
                if (person.Age>30)
                {
                    family.AddMembers(person);
                }
            }
            List<Person> list = new List<Person>();
            list=family.People.OrderBy(x => x.Name).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                string name = list[i].Name;
                int age = list[i].Age;
                Console.WriteLine($"{name} - {age}");
            }
        }
    }
}