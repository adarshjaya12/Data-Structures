using Datastructures.Linked_List;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Stack
{
    public class Stacks<T>
    {
        int ArrayCount;
        public Stacks()
        {
            n = 0;
            ArrayCount = 5;
            StackArray = new T[ArrayCount];
        }
        public T[] StackArray;
        public int n;

        public void Push(T item)
        {
            if(ArrayCount == n)
            {
                Console.WriteLine("RESIZING ARRAY");
                ResizeArray();
            }
            StackArray[n] = item;
            n++;
        }

        public void Pop()
        {
            StackArray[n] = default(T);
            n--;
        }


        public void ResizeArray()
        {
            int newLength = StackArray.Length * 2;
            var newArray = new T[newLength];

            for(int i = 0; i < StackArray.Length; i++)
            {
                newArray[i] = StackArray[i];
            }
            StackArray = newArray;
        }


        public void PrintAllItems()
        {
            Console.WriteLine("Printing All Stack");
            for(int i =0; i< n; i++)
            {
                Console.WriteLine(StackArray[i]);
            }
            Console.WriteLine("END OF PRINTING");
        }

        public bool isEmpty()
        {
            return n == 0;
        }

    }

    public class StackNodes<T>
    {
        public StackNodes<T> NextNode;
        public T Value;
    }

    public class LinkedListStack<T>
    {
        private StackNodes<T> Head;


        //Pop
        public void Pop()
        {
            if(Head != null)
            {
                var newHead = Head.NextNode;
                Head = newHead;
            }
            else
            {
                Console.WriteLine("The Stack is Empty");
            }
        }
        //Push
        public void Push(T itemValue)
        {
            StackNodes<T> node = new StackNodes<T>();
            node.Value = itemValue;

            if(Head == null)
            {
                Head = node;
            }
            else
            {
                var oldHeadNode = Head;
                node.NextNode = oldHeadNode;
                Head = node;
            }
        }

        //IsEmpty
        public bool IsEmpty()
        {
            return Head == null;
        }

        //Print All

        public void PrintAll()
        {
            Console.WriteLine("Printing All Item in Linked Stack");
            StackNodes<T> CurrentNode = Head;
            while(CurrentNode != null)
            {
                Console.WriteLine(CurrentNode.Value);
                CurrentNode = CurrentNode.NextNode;
            }
            Console.WriteLine("End Printing");
        }
    }
}
