using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public Catalog(string name,int neededRenovators,string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            renovators= new List<Renovator>();
        }
        public int Count { get { return renovators.Count; } }
        public string AddRenovator(Renovator renovator)
        {
            if (renovator.Name==null||renovator.Type==null)
            {
                return "Invalid renovator's information.";
            }
            else if (renovators.Count>=NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate>350)
            {
                return "Invalid renovator's rate.";
            }
            else
            {
                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
        }

        public bool RemoveRenovator(string name)
        {
            foreach (var item in renovators)
            {
                if (item.Name==name)
                {
                    renovators.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = 0;
            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Type == type)
                {
                    renovators.RemoveAt(i);
                    count++;
                }
            }
            return count;
        }

        public Renovator HireRenovator(string name)
        {
            foreach (var renovator in renovators)
            {
                if (renovator.Name==name)
                {
                    renovator.Hired = true;
                    return renovator;
                    
                }
            }
            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> list = new List<Renovator>();
            foreach (var item in renovators)
            {
                if (item.Days>=days)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var item in renovators)
            {
                if (item.Hired==false)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString().Trim();
        }
    }
}
