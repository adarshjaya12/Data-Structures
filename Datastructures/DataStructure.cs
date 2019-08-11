using Datastructures.Linked_List;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    class DataStructure
    {

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
        public static void Main(string[] args)
        {
            //TestSingleLinkedList();
            TestDoubleLinkedList();
        }
    }
}
