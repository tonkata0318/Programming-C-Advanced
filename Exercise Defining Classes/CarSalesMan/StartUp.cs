using System.Drawing;
using System.Globalization;

namespace CarSalesMan
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines1= new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                Engine engine= new Engine();
                string[] engines = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = engines[0];
                int power = int.Parse(engines[1]);
                int displacement = 0;
                string efficienty = "";
                if (engines.Length == 3)
                {
                    try
                    {
                        displacement = int.Parse(engines[2]);
                        engine.Displacement = displacement;
                    }
                    catch (Exception)
                    {
                        efficienty= engines[2];
                        engine.Efficiency = efficienty;
                    }
                }
                if (engines.Length==4)
                {
                    displacement = int.Parse(engines[2]);
                    efficienty= engines[3];
                    engine.Displacement = displacement;
                    engine.Efficiency= efficienty;
                }
                engine.Model=model;
                engine.Power=power;
                engines1.Add(engine);
            }
            int m=int.Parse(Console.ReadLine());
            List<Car> cars = new();
            for (int i = 0; i < m; i++)
            {

                Engine engine2=new Engine();
                string[] carInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model= carInput[0];
                string NameOfengine = carInput[1];
                int indexforengine = 0;
                for (int j = 0; j <engines1.Count; j++)
                {
                    if (engines1[j].Model==NameOfengine)
                    {
                        indexforengine = j;
                    }
                }
                int weight = 0;
                string colour = null;
                if (carInput.Length==3)
                {
                    try
                    {
                        weight = int.Parse(carInput[2]);
                    }
                    catch (Exception)
                    {
                        colour = carInput[2];
                    }
                }
                if (carInput.Length==4)
                {
                    weight = int.Parse(carInput[2]);
                    colour= carInput[3];
                }
                Car car = new Car(model, engines1[indexforengine], weight, colour);
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                car.ToString();
            }
        }
    }
}