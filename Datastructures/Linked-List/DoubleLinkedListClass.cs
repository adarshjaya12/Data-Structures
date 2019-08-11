using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Linked_List
{

    public class DoubleLinkedList
    {
        public class DoubleNodes
        {
            public DoubleNodes NextValue;
            public DoubleNodes PreviousValue;
            public int value;
        }

        public DoubleNodes Head;
        public DoubleNodes Tail;
        int listCount;

        public void AddItem(int insertValue,Position position,int index = 0)
        {
            DoubleNodes node = new DoubleNodes();
            node.value = insertValue;
            AddtoList(node, position, index);
        }

        public void RemoveItem(Position position, int index = 0)
        {
            RemoveFromList(position, index);
        }
        private void AddtoList(DoubleNodes item, Position addPosition,int index)
        {
            if(Head == null)
            {
                Head = item;
                Tail = item;
                listCount = 1;
            }
            else
            {
                if (addPosition == Position.END)
                {
                    DoubleNodes previousNode = null;
                    for (DoubleNodes node = Head; node != null; node = node.NextValue)
                    {
                        if(node.NextValue == null)
                        {
                            item.PreviousValue = node;
                            node.NextValue = item;
                            Tail = item;
                            listCount++;

                        }
                    }
                }
                else if(addPosition == Position.BEGIN)
                {
                    var oldHeadItem = Head;
                    oldHeadItem.PreviousValue = item;
                    item.NextValue = oldHeadItem;
                    Head = item;
                    listCount++;
                }
                else if(addPosition == Position.MIDDLE)
                {
                     if(index <= listCount)
                    {
                        int counter = 0;
                        DoubleNodes current = Head;
                        while (current != null)
                        {
                            if(counter + 1 == index)
                            {
                                var movingNode = current.NextValue;
                                movingNode.PreviousValue = item;

                                item.PreviousValue = current;
                                item.NextValue = movingNode;

                                current.NextValue = item;
                                break;
                            }
                            current = current.NextValue;
                            counter++;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Incorrect Index");
                    }
                }
            }
        }

        private void RemoveFromList(Position removePosition, int index)
        {
            if(removePosition == Position.BEGIN)
            {
                var nextItemAfterHead = Head.NextValue;
                nextItemAfterHead.PreviousValue = null;
                Head = nextItemAfterHead;
                listCount--;
            }
            else if(removePosition == Position.END)
            {
                for (DoubleNodes node = Head; node != null; node = node.NextValue)
                {
                    if (node.NextValue.NextValue == null)
                    {
                        Tail = node;
                        node.NextValue = null;
                        listCount--;
                        break;
                    }
                }
            }
            else if(removePosition == Position.MIDDLE)
            {
                if (index <= listCount)
                {
                    int counter = 0;
                    DoubleNodes current = Head;
                    while (current != null)
                    {
                        if (counter + 1 == index)
                        {
                            var movingNode = current.NextValue.NextValue;
                            current.NextValue = movingNode;
                            movingNode.PreviousValue = current;
                            break;
                        }
                        current = current.NextValue;
                        counter++;
                    }

                }
                else
                {
                    Console.WriteLine("Incorrect Index");
                }
            }
        }

        public void PrintAllList()
        {
            DoubleNodes current = Head;
            Console.WriteLine("PRINT ALL DOUBLE LINKED LIST");
            while(current != null)
            {
                Console.WriteLine(current.value);
                current = current.NextValue;
            }
        }

        public void PrintAllReverse()
        {
            DoubleNodes current = Tail;
            Console.WriteLine("PRINT ALL DOUBLE LINKED LIST IN REVERSE");
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.PreviousValue;
            }
        }
    }
}
