using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class DynamicQueue<T> : DynamicArray<T>
    {
        public DynamicQueue(int maxQueueSize) : base(maxQueueSize)
        {
            TypeOfArray = "Dynamic Queue";
        }

        public void Enqueue(T value)
        {
            Add(value);
        }

        public void Dequeue()
        {
            Console.WriteLine("{0} will be removed.", Get(0));
            Remove(0);
        }
    }
}
