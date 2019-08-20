using Datastructures.Linked_List;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Queue
{
    class TNodes<T>
    {
        public TNodes<T> NextNode;
        public T value;
    }
    public class LinkedListQueue<T>
    {
        TNodes<T> Front;
        TNodes<T> Back;

        public void Enqueue(T item)
        {
            if(Front == null)
            {
                Front.value = item;
                Back = Front;
            }
            else
            {
                TNodes<T> newNode = new TNodes<T>();
                newNode.value = item;
                Back.NextNode = newNode;
                Back = newNode;
            }
        }

        public void Dequeue()
        {

        }

    }
}
