using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListryIteratorClass<T>
    { 
        private int index;
        private List<T> list;
        public ListryIteratorClass(List<T> list)
        {
            this.list= list;
        }
        public bool Move()
        {
            if (index<list.Count-1)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return index< list.Count-1;
        }
        public void Print()
        {
            if (list.Count>0)
            {
                Console.WriteLine(list[index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
        
    }
}
