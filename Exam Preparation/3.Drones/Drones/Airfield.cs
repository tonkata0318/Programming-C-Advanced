using System.Collections.Generic;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip   { get; set; }
        public Airfield(string name,int capacity,double landingstrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingstrip;
            Drones=new List<Drone>();
        }
        public int Count { get { return Drones.Count; } }
        public string AddDrone(Drone drone)
        {
            if (drone.Name==null||drone.Brand==null)
            {
                return "Invalid drone.";
            }
            else if (drone.Range<5||drone.Range>15)
            {
                return "Invalid drone.";
            }
            else if (Drones.Count>=Capacity)
            {
                return "Airfield is full."; 
            }
            else
            {
                Drones.Add(drone);
                return $"Successfully added {drone.Name} to the airfield.";
            }
        }
        public bool RemoveDrone(string name)
        {
            for (int i = 0; i < Drones.Count; i++)
            {
                if (Drones[i].Name==name)
                {
                    Drones.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = 0;
            for (int i = 0; i < Drones.Count; i++)
            {
                if (Drones[i].Brand == brand)
                {
                    Drones.RemoveAt(i);
                    i--;
                    count++;
                }
            }
            return count;
        }
        public Drone FlyDrone(string name)
        {
            foreach (var item in Drones)
            {
                if (item.Name==name)
                {
                    item.Available = false;
                    return item;
                }
            }
            return null;
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> list=new List<Drone>();
            foreach (var item in Drones)
            {
                if (item.Range>=range)
                {
                    item.Available = false;
                    list.Add(item);
                }
            }
            return list;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");
            foreach (var item in Drones)
            {
                if (item.Available==true)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
