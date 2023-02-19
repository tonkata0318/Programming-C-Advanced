using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private int count;
        private List<T> data;
        public Box()
        {
            data=new List<T>();
        }
        public int Count { get { return this.count; } }
        public void Add(T item)
        {
            count++;
            data.Add(item);
        }
        public T Remove()
        {
            count--;
            T rem = data[data.Count - 1];
            data.Remove(rem);
            return rem;
        }
    }
}
