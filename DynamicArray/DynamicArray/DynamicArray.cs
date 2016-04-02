using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class DynamicArray<T>
    {
        private T[] dynamicArray;
        private int _capacity = 0;
        private int _size = 0;
        private int _position = 0;

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public DynamicArray()
        {
            this.dynamicArray = new T[Capacity];
        }

        public void Add(T value)
        {
            if (Capacity == 0)
            {
                Capacity = Size = 1;
                dynamicArray = new T[Capacity];
                dynamicArray[Position] = value;
            }
            else
            {
                if (Size == Capacity)
                {
                    EnlageArrayCapacity();
                }
                Position++;
                dynamicArray[Position] = value;
                Size++;
            }
        }

        private void EnlageArrayCapacity()
        {
            T[] tempArray = dynamicArray;
            Capacity = Capacity*2;
            dynamicArray = new T[Capacity];
            for (int i = 0; i < Size; i++)
            {
                dynamicArray[i] = tempArray[i];
            }
        }

        public void Insert(int insertPosition, T value)
        {
            if (insertPosition >= 0 && insertPosition <= Size)
            {
                if (Size == Capacity)
                {
                    EnlageArrayCapacity();
                }

                if (insertPosition == Position+1)
                {
                    Add(value);
                }
                else
                {
                    if (insertPosition <= Position)
                    {
                        T[] tempArray = dynamicArray;
                        dynamicArray = new T[Capacity];
                        
                        for (int i = 0; i < insertPosition; i++)
                        {
                            dynamicArray[i] = tempArray[i];
                        }
                        
                        dynamicArray[insertPosition] = value;
                        Size++;
                        
                        for (int i = insertPosition+1; i < Size+1; i++)
                        {
                            dynamicArray[i] = tempArray[i-1];
                        }
                        Position = Size;
                    }
                }
            }
            else
            {
                Console.WriteLine("Inserting position is out of Array's size");
            }
        }

        public T Get(int position)
        {
            if (position >= 0 && position < Size)
            {
                return dynamicArray[position];
            }
            return default (T);
        }

        public void Remove(int removePosition)
        {
            if (removePosition >= 0 && removePosition <= Size)
            {
                if (removePosition <= Position)
                {
                    T[] tempArray = dynamicArray;
                    dynamicArray = new T[Capacity];

                    for (int i = 0; i < removePosition; i++)
                    {
                        dynamicArray[i] = tempArray[i];
                    }

                    Size--;

                    for (int i = removePosition + 1; i < Size + 1; i++)
                    {
                        dynamicArray[i-1] = tempArray[i];
                    }
                    Position = Size - 1;
                }
            }
            else
            {
                Console.WriteLine("Removing position is out of Array's size");
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write("{0} ", dynamicArray[i]);
            }
            Console.WriteLine();
        }

    }
}
