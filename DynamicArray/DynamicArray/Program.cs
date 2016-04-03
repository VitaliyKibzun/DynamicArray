using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>(6);
            DynamicQueue<int> queue = new DynamicQueue<int>(3);
            DynamicStack<int> stack = new DynamicStack<int>(4);
            array.Add(5);
            array.Add(6);
            array.Add(7);
            array.Add(8);
            array.PrintArray();
            Console.WriteLine(array.Get(-1));
            Console.WriteLine(array.Get(10).ToString());
            Console.WriteLine(array.Get(3));
            array.Insert(10, 9);
            array.Insert(4, 9);
            array.PrintArray();
            array.Insert(2, 10);
            array.PrintArray();
            array.Insert(4, 11);
            array.PrintArray();
            array.Remove(4);
            array.PrintArray();
            array.Remove(5);
            array.PrintArray();
            array.Remove(10);
            array.PrintArray();

            Console.WriteLine();
            queue.Dequeue();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.PrintArray();
            queue.Dequeue();
            queue.PrintArray();

            Console.WriteLine();
            stack.Pop();
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.PrintArray();
            stack.Pop();
            stack.PrintArray();


            Console.ReadKey();
        }
    }
}
