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
                Front = new TNodes<T>();
                Back = new TNodes<T>();
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
            if(Front != null && Front.NextNode != null)
            {
                var removingItem = Front;
                Front = removingItem.NextNode;
            }
            else
            {
                Console.WriteLine("No more item to remove");
            }
           
        }


        public void PrintItems()
        {
            var loopItem = Front;
            Console.WriteLine("Printing Queue \n\n");
            while(loopItem != null)
            {
                Console.Write(loopItem.value);
                loopItem = loopItem.NextNode;
            }
            Console.WriteLine("\nEnd");
        }
        public bool IsEmpty()
        {
            return Front == null;
        }

    }
}
