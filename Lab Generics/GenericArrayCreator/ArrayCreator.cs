using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int lentgh,T element)
        {
            T[] array=new T[lentgh];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = element;
            }
            return array;
        }
    }
}
