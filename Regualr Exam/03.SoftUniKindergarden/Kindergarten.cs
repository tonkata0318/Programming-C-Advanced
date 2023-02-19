using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        private List<Child> Registry;

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry= new List<Child>();
        }

        public bool AddChild(Child child)
        {
            if (Registry.Count<Capacity)
            {
                Registry.Add(child);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveChild(string childFullName)
        {
            for (int i = 0; i < Registry.Count; i++)
            {
                string cuurentFullname = Registry[i].FirstName + " " + Registry[i].LastName;
                if (cuurentFullname==childFullName)
                {
                    Registry.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public int ChildrenCount { get { return Registry.Count; } }

        public Child GetChild(string childFullName)
        {
            Child child=null;
            for (int i = 0; i < Registry.Count; i++)
            {
                string cuurentFullname = Registry[i].FirstName + " " + Registry[i].LastName;
                if (cuurentFullname == childFullName)
                {
                    child= Registry[i];
                }
            }
            return child;
        }
        public string RegistryReport()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (var item in Registry.OrderByDescending(x=>x.Age).ThenBy(x=>x.LastName).ThenBy(x=>x.FirstName))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
