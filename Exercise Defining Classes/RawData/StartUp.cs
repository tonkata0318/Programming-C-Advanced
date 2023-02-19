namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            List<Car> cars= new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(
                    input[0],
                    int.Parse(input[1]),
                    int.Parse(input[2]),
                    int.Parse(input[3]),
                    input[4],
                    double.Parse(input[5]),
                    int.Parse(input[6]),
                    double.Parse(input[7]),
                    int.Parse(input[8]),
                    double.Parse(input[9]),
                    int.Parse(input[10]),
                    double.Parse(input[11]),
                    int.Parse(input[12])
                    );
                cars.Add(car);
            }
            string type=Console.ReadLine();
            if (type=="fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType=="fragile" && car.Tyres.Any(p=>p.Pressure<1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType == "flammable" && car.Engine.Power>250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}