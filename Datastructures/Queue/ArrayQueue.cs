using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Queue
{
    //The Array implementation contains a Front and the Back pointer where the back pointer gets added when a new item is added
    // enqueue  to add an item and dequeue to remove an item
    public class ArrayQueue<T>
    {
        int Front;
        int Back;

        T[] QueueArray;
        int ArrayLength;
        public ArrayQueue()
        {
            ArrayLength = 10;
            QueueArray = new T[ArrayLength];
        }

        public void Enqueue(T item)
        {
            QueueArray[Back] = item;
            Back++;
        }
        public void Dequeue()
        {
            QueueArray[Front] = default(T);
            Front++;
        }

        public bool IsQueueEmpty()
        {
            return Front == Back;
        }

        public void PrintAllInQueue()
        {
            Console.WriteLine("Printing Queue Items");
            for(int i = Front; i < Back; i++)
            {
                Console.WriteLine(QueueArray[i]);
            }
            Console.WriteLine("End of printing");
        }
    }
}
