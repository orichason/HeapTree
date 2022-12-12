using System;
using System.Collections.Generic;

namespace HeapTree
{

    class Program
    {
        static void Main(string[] args)
        {
            MinHeap<int> HeapTree = new MinHeap<int>();

            HeapTree.Insert(5);
            HeapTree.Insert(3);
            HeapTree.Insert(10);
            HeapTree.Insert(1);
            HeapTree.Insert(7);
            Console.WriteLine(HeapTree.Pop());
            Console.WriteLine(HeapTree.Pop());
            Console.WriteLine(HeapTree.Pop());
            Console.WriteLine(HeapTree.Pop());
            HeapTree.Insert(30);

            
        }
    }
}
