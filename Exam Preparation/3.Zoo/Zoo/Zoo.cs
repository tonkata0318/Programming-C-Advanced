using System.Collections.Generic;

namespace Zoo
{
    public class Zoo
    {
        public List<Animal> Animals;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Zoo(string name, int capacity)
        {
            Animals = new List<Animal>();
            Name = name;
            Capacity = capacity;
        }
        public string AddAnimal(Animal animal)
        {
            if (animal.Species == null||animal.Species==" ")
            {
                return "Invalid animal species.";
            }
            else if (animal.Diet!= "herbivore"&&animal.Diet!= "carnivore")
            {
                return "Invalid animal diet.";
            }
            else if (Animals.Count>=Capacity)
            {
                return "The zoo is full.";
            }
            else
            {
                Animals.Add(animal);
                return $"Successfully added {animal.Species} to the zoo.";
            }
        }
        public int RemoveAnimals(string species)
        {
            int count = 0;
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].Species==species)
                {
                    Animals.RemoveAt(i);
                    i--;
                    count++;
                }
            }
            return count;
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> list = new List<Animal>();
            foreach (var item in Animals)
            {
                if (item.Diet==diet)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public Animal GetAnimalByWeight(double weight)
        {
            int index = 0;
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].Weight==weight)
                {
                    index = i;
                }
            }
            return Animals[index];
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;
            foreach (var item in Animals)
            {
                if (item.Length>=minimumLength&&item.Length<=maximumLength)
                {
                    count++;
                }
            }
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
