using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> Ingredients;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Ingredients = new List<Ingredient>();
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }
        public void Add(Ingredient ingredient)
        {
            bool hasSameName = false;
            foreach (var item in Ingredients)
            {
                if (item.Name==ingredient.Name)
                {
                    hasSameName= true;
                }
            }
            if (hasSameName==false&&Ingredients.Count<Capacity)
            {
                Ingredients.Add(ingredient);
            }
        }
        public bool Remove(string name)
        {
            for (int i = 0; i < Ingredients.Count; i++)
            {
                if (Ingredients[i].Name==name)
                {
                    Ingredients.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public Ingredient FindIngredient(string name)
        {
            Ingredient ingredient = null;
            foreach (var item in Ingredients)
            {
                if (item.Name==name)
                {
                    ingredient = item;
                }
            }
            return ingredient;
        }
        public Ingredient GetMostAlcoholicIngredient()
        {
            Ingredient ingredient= null;
            int mostAlcoloh = int.MinValue;
            int index = 0;
            for (int i = 0; i < Ingredients.Count; i++)
            {
                if (Ingredients[i].Alcohol>mostAlcoloh)
                {
                    mostAlcoloh = Ingredients[i].Alcohol;
                    index = i;
                }
            }
            ingredient = Ingredients[index];
            return ingredient;
        }
        public int CurrentAlcoholLevel { get { return Ingredients.Count; }}
        
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (var item in Ingredients)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
