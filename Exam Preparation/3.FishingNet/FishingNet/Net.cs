using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public List<Fish> Fish;
        public string Material { get; set; }
        public int Capacity { get; set; }
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish=new List<Fish>();
        }
        public int Count { get { return Fish.Count; }}
        public string AddFish(Fish fish)
        {
            if (fish.FishType==null || fish.FishType==" ")
            {
                return "Invalid fish.";
            }
            else if (fish.Length<=0||fish.Weight<=0)
            {
                return "Invalid fish.";
            }
            else if (Fish.Count>=Capacity)
            {
                return "Fishing net is full.";
            }
            else
            {
                Fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
        }
        public bool ReleaseFish(double weight)
        {
            for (int i = 0; i < Fish.Count; i++)
            {
                if (Fish[i].Weight==weight)
                {
                    Fish.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public Fish GetFish(string fishType)
        {
            int index = 0;
            for (int i = 0; i < Fish.Count; i++)
            {
                if (Fish[i].FishType==fishType)
                {
                    index = i;
                }
            }
            return Fish[index];
        }
        public Fish GetBiggestFish()
        {
            int index = 0;
            double longest = double.MinValue;
            for (int i = 0; i < Fish.Count; i++)
            {
                if (Fish[i].Length>=longest)
                {
                    longest = Fish[i].Length;
                    index = i;
                }
            }
            return Fish[index];
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            foreach (var item in Fish.OrderByDescending(x=>x.Length))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
