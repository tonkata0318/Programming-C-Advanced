using System.Collections.Generic;
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> multiProccesor;
        private string model;
        private int capacity;
        public string Model { get { return this.model; } set { this.model = value; } }   
        public int Capacity { get { return this.capacity; } set { this.capacity = value; } }
        public List<CPU> Multiprocessor { get { return this.multiProccesor; } set { this.multiProccesor = value; } }

        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor= new List<CPU>();
        }

        public int Count { get { return this.Multiprocessor.Count; }}
        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count<Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }
        public bool Remove(string brand)
        {
            foreach (var item in Multiprocessor)
            {
                if (item.Brand==brand)
                {
                    Multiprocessor.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public CPU MostPowerful()
        {
            double biggest = 0d;
            int index = 0;
            for (int i = 0; i < Multiprocessor.Count; i++)
            {
                if (Multiprocessor[i].Frequency>biggest)
                {
                    biggest = Multiprocessor[i].Frequency;
                    index = i;
                }
            }
            return Multiprocessor[index];
        }
        public CPU GetCPU(string brand)
        {
            int index = 0;
            for (int i = 0; i < Multiprocessor.Count; i++)
            {
                if (Multiprocessor[i].Brand==brand)
                {
                    index = i;
                    return Multiprocessor[index];
                }
            }
            return null;
        }
        public string Report()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {this.Model}:");
            foreach (var item in Multiprocessor)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }
    }
}
