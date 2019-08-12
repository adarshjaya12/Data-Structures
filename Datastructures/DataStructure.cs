using Datastructures.Linked_List;
using Datastructures.Stack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    class DataStructure
    {
        #region LinkedList
        public static void TestSingleLinkedList()
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("LINKED LIST ");
            Console.WriteLine("The List is empty, Add an integer to the list");
            var input = Console.ReadLine();
            list.AddItem(int.Parse(input), Position.BEGIN);
            list.AddItem(1, Position.BEGIN);
            list.AddItem(4, Position.BEGIN);
            list.AddItem(5, Position.BEGIN);
            list.AddItem(3, Position.MIDDLE, 2);
            list.AddItem(2, Position.MIDDLE, 2);
            list.PrintAllList();
            Console.WriteLine("Now Removing item at index 3");
            list.RemoveItem(Position.MIDDLE, 3);
            list.PrintAllList();

            Console.WriteLine("Now Removing head element");
            list.RemoveItem(Position.BEGIN);
            list.PrintAllList();

            Console.WriteLine("Now Removing tail element");
            list.RemoveItem(Position.END);
            list.PrintAllList();

            Console.ReadLine();
        }

        public static void TestDoubleLinkedList()
        {
            DoubleLinkedList list = new DoubleLinkedList();
            Console.WriteLine("LINKED LIST ");
            Console.WriteLine("The List is empty, Add an integer to the list");
            var input = Console.ReadLine();
            list.AddItem(int.Parse(input), Position.BEGIN);
            list.AddItem(1, Position.BEGIN);
            list.AddItem(4, Position.BEGIN);
            list.AddItem(5, Position.BEGIN);
            list.AddItem(3, Position.MIDDLE, 2);
            list.AddItem(2, Position.MIDDLE, 2);
            list.PrintAllList();
            Console.WriteLine("Now Removing item at index 3");
            list.RemoveItem(Position.MIDDLE, 3);
            list.PrintAllList();

            Console.WriteLine("Now Removing head element");
            list.RemoveItem(Position.BEGIN);
            list.PrintAllList();

            Console.WriteLine("Now Removing tail element");
            list.RemoveItem(Position.END);
            list.PrintAllList();

            list.PrintAllReverse();

            Console.ReadLine();
        }
        #endregion

        #region Stack
        
        public static void TestStack()
        {
            Stacks<int> newStack = new Stacks<int>();
            newStack.Push(10);
            newStack.Push(7);
            newStack.Push(2);
            newStack.Push(6);
            newStack.PrintAllItems();
            newStack.Push(1);
            newStack.Push(2);
            newStack.PrintAllItems();
            Console.ReadLine();
        }

        public static void LinkedListStack()
        {
            LinkedListStack<int> linkedListStack = new LinkedListStack<int>();
            linkedListStack.Push(10);
            linkedListStack.Push(9);
            linkedListStack.Push(8);
            linkedListStack.Push(7);
            linkedListStack.Push(6);
            linkedListStack.Push(5);
            linkedListStack.PrintAll();
            linkedListStack.Pop();
            linkedListStack.Pop();
            linkedListStack.PrintAll();
            Console.Read();
        }

        #endregion

        public static void Main(string[] args)
        {
            //TestSingleLinkedList();
            //TestDoubleLinkedList();
            //TestStack();
            LinkedListStack();
        }
    }
}
