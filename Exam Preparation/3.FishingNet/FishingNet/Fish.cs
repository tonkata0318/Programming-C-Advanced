using System.Text;

namespace FishingNet
{
    public class Fish
    {
        public string FishType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public Fish(string fishType, double length, double weight)
        {
            FishType = fishType;
            Length = length;
            Weight = weight;
        }
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"There is a {FishType}, {Length} cm. long, and {Weight} gr. in weight.");
            return sb.ToString().Trim();
        }
    }
}
