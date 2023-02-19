namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();
            ListryIteratorClass<string> listy = new(items);
            string command = string.Empty;
            while ((command=Console.ReadLine())!="END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Print":
                        listy.Print();
                        break;
                }
            }

        }
    }
}