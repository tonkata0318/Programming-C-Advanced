using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public SkiRental(string name, int capacity)
        {
            data= new List<Ski>();
            Name = name;
            Capacity = capacity;
        }
        public void Add(Ski ski)
        {
            if (data.Count<Capacity)
            {
                data.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Manufacturer == manufacturer && data[i].Model==model)
                {
                    data.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public Ski GetNewestSki()
        {
            int newestYear = int.MinValue;
            Ski ski = null;
            foreach (var item in data)
            {
                if (item.Year>newestYear)
                {
                    newestYear = item.Year;
                    ski=item;
                }
            }
            return ski;
        }
        public Ski GetSki(string manufacturer, string model)
        {
            Ski ski = null;
            foreach (var item in data)
            {
                if (item.Manufacturer==manufacturer&&item.Model==model)
                {
                    ski = item;
                }
            }
            return ski;
        }
        public int Count { get { return data.Count; } }
        public string GetStatistics()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
