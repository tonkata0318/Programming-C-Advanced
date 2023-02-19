using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapInteger
{
    public class Box<T>
    {
        private T value;
        public T Value { get { return this.value; } set { this.value = value; } }
        private List<T> list;
        public List<T> List { get { return this.list; } set { this.list = value; } }
        public Box()
        {
            list = new List<T>();
        }
        public override string ToString()
        {
            return $"{typeof(T)}: {value}";
        }
        public void Swap(int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
