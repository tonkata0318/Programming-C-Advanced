namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           string[] nameAndAdress=Console.ReadLine().Split(" ");
            Tuple<string, string, string> name=new Tuple<string, string, string>(nameAndAdress[0], nameAndAdress[1], nameAndAdress[2]);
            string[] nameAndBears = Console.ReadLine().Split(" ");
            Tuple<string, int> namewithbears = new Tuple<string, int>(nameAndBears[0], int.Parse(nameAndBears[1]));
            string[] integersAndDoubles = Console.ReadLine().Split(" ");
            Tuple<int, double> intsandDouble = new Tuple<int, double>(int.Parse(integersAndDoubles[0]), double.Parse(integersAndDoubles[1]));
            Console.WriteLine($"{name.Item1} {name.Item2} -> {name.Item3}");
            Console.WriteLine($"{namewithbears.Item1} -> {namewithbears.Item2}");
            Console.WriteLine($"{intsandDouble.Item1} -> {intsandDouble.Item2}");

        }
    }
}