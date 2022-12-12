﻿using System;
namespace HeapTree
{
    public class MinHeap<T> where T : IComparable
    {
        public int Count { get; private set; }
        private T[] data;

        public MinHeap()
        {
            Count = 0;
            data = new T[4];
        }

        private bool IsEmpty()
        {
            return Count == 0;
        }

        private void ReSize()
        {
            T[] resizedData = new T[data.Length * 2];

            for (int i = 0; i < data.Length; i++)
            {
                resizedData[i] = data[i];
            }

            data = resizedData;
        }

        private int LeftChildIndex(int index)
        {
            return (2 * index) + 1;
        }

        private int RightChildIndex(int index)
        {
            return LeftChildIndex(index) + 1;
        }

        private int Parent(int index)
        {
            return (index - 1) / 2;
        }

        public void Insert(T item)
        {
            if (Count == data.Length)
            {
                ReSize();
            }
            data[Count] = item;
            HeapifyUp(Count);
            Count++;
        }

        private void HeapifyUp(int index)
        {

            int parentIndex = Parent(index);

            if (data[index].CompareTo(data[parentIndex]) < 0)
            {
                T temp = data[parentIndex];
                data[parentIndex] = data[index];
                data[index] = temp;
                HeapifyUp(parentIndex);

            }

            return;

        }

        public T Pop()
        {
            if(IsEmpty()) throw new InvalidOperationException("Nothing left to pop fool");
            
            T poppedValue = data[0];
            data[0] = data[Count - 1];
            Count--;
            HeapifyDown(0);
            return poppedValue;
        }

        private void HeapifyDown(int index)
        {
            int leftChild = LeftChildIndex(index);


            if (leftChild >= Count) return;

            int rightChild = RightChildIndex(index);
            int smallestChild;

            if (data[leftChild].CompareTo(data[rightChild]) < 0)
            {
                smallestChild = leftChild;               
            }

            else
            {
                smallestChild = rightChild;

            }

            if (data[index].CompareTo(data[smallestChild]) > 0)
            {
                T temp = data[index];
                data[index] = data[smallestChild];
                data[smallestChild] = temp;
                index = smallestChild;
            }

            else return;

            HeapifyDown(index);

        }
    }
}
