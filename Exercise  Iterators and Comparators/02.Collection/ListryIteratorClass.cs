using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Collection
{
    public class ListryIteratorClass<T> : IEnumerable<T>
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
        public void PrintAll()
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return list[index];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
