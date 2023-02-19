namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            box.List = new List<double>();
            for (int i = 0; i < n; i++)
            {
                box.List.Add(double.Parse(Console.ReadLine()));
            }
            double elementtoCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(box.CountOfBiggerEl(elementtoCompare));
        }
    }
}