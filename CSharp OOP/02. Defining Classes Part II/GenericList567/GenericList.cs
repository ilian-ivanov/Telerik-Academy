using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList567
{
    public class GenericList<T>
        where T : IComparable<T>
    {
        private uint capacity;
        private T[] genList;
        private uint count = 0;

        // CONSTRUCTORS -------------------------------------------------
        public GenericList(uint capacity)
        {
            this.capacity = capacity;
            this.genList = new T[this.capacity];
        }

        // PROPERTIES ---------------------------------------------------
        public uint Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public uint Count
        {
            get
            {
                return this.count;
            }
        }

        // METHODS ------------------------------------------------------     
        private void MakeDoubleCapacity(T[] oldList)
        {
            this.capacity = 2 * this.capacity;
            this.genList = new T[this.capacity];

            for (int i = 0; i < this.count; i++)
            {
                this.genList[i] = oldList[i];
            }
        }
        
        public void Add(T newElement)
        {
            if (this.count < this.capacity)
            {
                this.genList[this.count] = newElement;
                this.count++;
            }
            else
            {              
                MakeDoubleCapacity(this.genList);
                Add(newElement);
            }
        }

        public T TakeElement(uint index)
        {
            if (index < this.count)
            {
                return genList[index];
            }
            else
            {
                throw new IndexOutOfRangeException("The index is out of range!");
            }
        }

        public void RemoveElement(uint index)
        {
            if (index < this.count)
            {
                if (!(index == this.count - 1))
                {
                    for (uint i = index; i < this.count; i++)
                    {
                        this.genList[i] = this.genList[i + 1];
                    }
                }
                this.count--;
            }
            else
            {
                throw new IndexOutOfRangeException("The index is out of range!");
            }
        }

        public void Insert(T newElement, uint index)
        {
            if (index < this.count)
            {
                if (this.count < this.capacity)
                {
                    for (uint i = this.count; i > index; i--)
                    {
                        this.genList[i] = this.genList[i - 1];
                    }
                    this.genList[index] = newElement;
                    this.count++;
                }
                else
                {
                    MakeDoubleCapacity(this.genList);
                    Insert(newElement, index);
                }
            }
            else
            {
                throw new IndexOutOfRangeException("The index is out of range!");
            }
        }

        public void Clear()
        {
            this.genList = new T[this.capacity];
            count = 0;
        }

        // here return the index of element if it is exist or -1
        public int FindElement(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.genList[i].CompareTo(element) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            for (int i = 0; i < this.count; i++)
            {
                print.Append(genList[i]);
                print.Append(", ");
            }
            return print.ToString();
        }

        public T Min()
        {
            T min = this.genList[0];
            for (int i = 1; i < this.count; i++)
            {
                if (min.CompareTo(genList[i]) > 0)
                {
                    min = genList[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.genList[0];
            for (int i = 1; i < this.count; i++)
            {
                if (max.CompareTo(genList[i]) < 0)
                {
                    max = genList[i];
                }
            }
            return max;
        }  
    }
}