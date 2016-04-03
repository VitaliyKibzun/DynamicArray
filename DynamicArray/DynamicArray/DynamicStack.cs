using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class DynamicStack<T> : DynamicArray<T>
    {
        public DynamicStack(int maxStackSize) : base(maxStackSize)
        {
            TypeOfArray = "Dynamic Stack";
        }
        
        public void Push(T value)
        {
            Add(value);
        }

        public void Pop()
        {
            Console.WriteLine("{0} will be removed.", Get(Position));
            Remove(Position);
        }
    }
}
