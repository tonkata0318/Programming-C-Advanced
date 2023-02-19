namespace GenericSwapMethodString
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
            string[] indexes=Console.ReadLine().Split(" ");
            box.Swap(int.Parse(indexes[0]), int.Parse(indexes[1]));
            for (int i = 0; i < box.List.Count; i++)
            {
                box.Value = box.List[i];
                Console.WriteLine(box.ToString());
            }
        }
    }
}