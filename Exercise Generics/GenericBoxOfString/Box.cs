using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private T value;
        public T Value { get { return this.value; } set { this.value = value; } }
        public override string ToString()
        {
            return $"{typeof(string)}: {value}";
        }
    }
}
