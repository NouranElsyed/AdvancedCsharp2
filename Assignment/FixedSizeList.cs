using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        public int Capacity { get; }
        public T[] values;

        public FixedSizeList(int capacity) 
        {
            if (capacity < 0)
                throw new Exception();

            if (capacity == 0)
                Console.WriteLine("List is empty");
            else
                values = new T[capacity];
        }
        public FixedSizeList()
        {
          
        }

        public void Add(T value)
        {
            if (values.Length < Capacity)
            {
                values[values.Length + 1] = value;
            }
            else
            {
                throw new Exception();
            }
        }
        
 

    }
}
