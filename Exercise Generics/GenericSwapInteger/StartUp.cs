namespace GenericSwapInteger
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            box.List = new List<int>();
            for (int i = 0; i < n; i++)
            {
                box.List.Add(int.Parse(Console.ReadLine()));
            }
            string[] indexes = Console.ReadLine().Split(" ");
            box.Swap(int.Parse(indexes[0]), int.Parse(indexes[1]));
            for (int i = 0; i < box.List.Count; i++)
            {
                box.Value = box.List[i];
                Console.WriteLine(box.ToString());
            }
        }
    }
}