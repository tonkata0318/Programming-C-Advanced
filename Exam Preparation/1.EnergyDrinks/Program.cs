Stack<int> miligramsOfCoffeine = new();
Queue<int> energydrinks = new();
int stamatlimit = 0;
int[] miligramsofCoffeine = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
for (int i = 0; i < miligramsofCoffeine.Length; i++)
{
    miligramsOfCoffeine.Push(miligramsofCoffeine[i]);
}
int[] enerGyDrinks= Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
for (int i = 0; i < enerGyDrinks.Length; i++)
{
    energydrinks.Enqueue(enerGyDrinks[i]);
}
while (stamatlimit<=300 &&miligramsOfCoffeine.Count> 0 && energydrinks.Count>0)
{
    int coffeinetoAccept= miligramsOfCoffeine.Peek() * energydrinks.Peek();
    if (coffeinetoAccept+stamatlimit>300)
    {
        miligramsOfCoffeine.Pop();
        int temp = energydrinks.Dequeue();
        energydrinks.Enqueue(temp);
        if (stamatlimit>=30)
        {
            stamatlimit -= 30;
        }
    }
    else
    {
        stamatlimit += coffeinetoAccept;
        miligramsOfCoffeine.Pop();
        energydrinks.Dequeue();
    }
}
if (energydrinks.Count>0)
{
    Console.WriteLine($"Drinks left: {string.Join(", ",energydrinks)}");
}
else
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}
Console.WriteLine($"Stamat is going to sleep with {stamatlimit} mg caffeine.");