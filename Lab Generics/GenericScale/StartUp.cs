namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> ints = new EqualityScale<int>(5,6);
            EqualityScale<string> strings = new EqualityScale<string>("Pesho", "Pesho");
            Console.WriteLine(ints.AreEqual().ToString());
            Console.WriteLine(strings.AreEqual().ToString());
        }
    }
}