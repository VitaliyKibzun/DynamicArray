using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    interface IDynamicArray<T>
    {
        void Add(T value);
        void Insert(T value);
        T Get(int position);
        void Remove(int position);
    }
}
