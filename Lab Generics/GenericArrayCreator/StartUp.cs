namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
            Console.Write(string.Join(" ",strings));
            Console.WriteLine();
            Console.Write(string.Join(" ",integers));
        }
    }
}