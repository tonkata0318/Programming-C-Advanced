using System.Text;

namespace Zoo
{
    public class Animal
    {
        public string Species { get; set; }
        public string Diet { get; set; }
        public double Weight { get; set; }

        public double Length { get; set; }
        public Animal(string species, string diet, double weight, double length)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Length = length;
        }
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"The {Species} is a {Diet} and weighs {Weight} kg.");
            return sb.ToString().Trim();
        }
    }
}
