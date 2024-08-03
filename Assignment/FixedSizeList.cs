using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T> :IList
    {
        public int size;

      

        public T[] values;

        //internal int _version;
        public T this[int index]
        {
            get
            {
                // Following trick can reduce the range check by one
                if ((uint)index >= (uint)size)
                {
                    //ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
                }
                return values[index];
            }

            set
            {
                if ((uint)index >= (uint)size)
                {
                    //ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
                }
                values[index] = value;
                //_version++;
            }
        }


        //
        public int Capacity
        {
            get => values.Length;
            set
            {
                if (value < size)
                {
                    //ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_SmallCapacity);
                }

                if (value != values.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (size > 0)
                        {
                            Array.Copy(values, newItems, size);
                        }
                        values = newItems;
                    }
                    else
                    {
                        values = new T[0];
                    }
                }
            }
        }

        object? IList.this[int index]
        {
            get => this[index];
            set
            {
                //ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);

                try
                {
                    this[index] = (T)value!;
                }
                catch (InvalidCastException)
                {
                    //ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
                }
            }
        }



        public FixedSizeList(int capacity)
        {
            this.Capacity = capacity;

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

        public void Add(T item)
        {
            //_version++;
            T[] array = values;
            int size = Capacity;
            if ((uint)size < (uint)array.Length)
            {
                Console.WriteLine("not of range");
            }
     
        }

        int IList.Add(object? item)
        { 

       
           
                Add((T)item!);
         

            return Count - 1;
        }




        #region not used 
        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Count => Capacity;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();


        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object? value)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object? value)
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

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}


