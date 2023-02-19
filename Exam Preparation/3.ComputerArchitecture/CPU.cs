using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        private string brand;
        private int cores;
        private double frequency;
        public string Brand { get { return brand; } set { this.brand= value; } }

        public int Cores { get { return cores; } set { this.cores= value; } }

        public double Frequency { get { return frequency;} set { this.frequency = value; } }

        public CPU(string brand,int cores,double frequncy)
        {
            this.Brand= brand;
            this.Cores= cores;
            this.Frequency= frequncy;
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"{this.Brand} CPU:");
            sb.AppendLine($"Cores: {this.Cores}");
            sb.AppendLine($"Frequency: {this.Frequency:f1} GHz");
            return sb.ToString();
        }
    }
}
