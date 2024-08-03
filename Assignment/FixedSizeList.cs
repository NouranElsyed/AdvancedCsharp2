using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;


namespace Assignment
{
    internal class FixedSizeList<T> : IList
    {
        internal int size;
        internal T[] items;
        //List<T> list = new List<T> ();
        public int Count => size;
        public int IndexOf(object? value)
        {
            if (IsCompatibleObject(value))
            {
                return IndexOf((T)value!);
            }
            return -1;
            //return items.IndexOf((T)value);
        }
        private static bool IsCompatibleObject(object? value)
        {
            // Non-null values are fine.  Only accept nulls if T is a class or Nullable<U>.
            // Note that default(T) is not equal to null for value types except when T is Nullable<U>.
            return (value is T) || (value == null && default(T) == null);
        }
        public object? this[int index] { get { return items[index]; } set { items[index] = (T)value; } }

        public bool IsFixedSize => true;

        public bool IsReadOnly => false;

        public bool IsSynchronized => false;

        public object SyncRoot => this;

        public int Add(object? value)
        {
            Add((T)value!);
            return Count - 1;
        }
        public void Add(T item)
        {
            //items.Add(item);

            T[] array = items;
            int Size = size;
            if ((uint)size < (uint)array.Length)
            {
                Size = size + 1;
                array[Size] = item;
            }
            else
            {
                throw new Exception();
            }
        }
        public FixedSizeList(int capacity)
        {
            size=capacity;
            if (capacity < 0)
                throw new Exception();

            else;
           
                items = new T[capacity];
        }

        public int Capacity
        {
            get => items.Length;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
        public bool Contains(object? value)
        {
            throw new NotImplementedException();
        }
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Insert(int index, object? value)
        {
            throw new NotImplementedException();
        }
        public void Remove(object? value)
        {
            throw new NotImplementedException();
        }
        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}


