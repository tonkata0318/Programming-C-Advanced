using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public List<Car> Participants;
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }

        public Race(string name,string type,int laps,int capacity,int maxhorsepower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower= maxhorsepower;
            Participants= new List<Car>();
        }
        public int Count { get { return Participants.Count; } }
        public void Add(Car car)
        {
            bool hasSame = false;
            foreach (Car participant in Participants)
            {
                if (participant.LicensePlate==car.LicensePlate)
                {
                    hasSame = true;
                }
            }
            if (Participants.Count<Capacity&&car.HorsePower<=MaxHorsePower)
            {
                Participants.Add(car);
                if (hasSame)
                {
                    Participants.Remove(car);
                }
            }
        }
        public bool Remove(string licensePlate)
        {
            bool isFound = false;
            for (int i = 0; i < Participants.Count; i++)
            {
                if (Participants[i].LicensePlate==licensePlate)
                {
                    Participants.RemoveAt(i);
                    isFound= true;
                }
            }
            return isFound;
        }
        public Car FindParticipant(string licensePlate)
        {
            Car car = null;
            foreach (Car participant in Participants)
            {
                if (participant.LicensePlate==licensePlate)
                {
                    car = participant;
                }
            }
            return car;
        }
        public Car GetMostPowerfulCar()
        {
            Car car=null;
            int mostHorsePower = int.MinValue;
            foreach (Car participant in Participants)
            {
                if (participant.HorsePower>mostHorsePower)
                {
                    mostHorsePower = participant.HorsePower;
                    car= participant;
                }
            }
            return car;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var item in Participants)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
