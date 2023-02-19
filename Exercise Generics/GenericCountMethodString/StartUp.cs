namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            box.List = new List<string>();
            for (int i = 0; i < n; i++)
            {
                box.List.Add(Console.ReadLine());
            }
            string elementtoCompare=Console.ReadLine();
            Console.WriteLine(box.CountOfBiggerEl(elementtoCompare));
        }
    }
}