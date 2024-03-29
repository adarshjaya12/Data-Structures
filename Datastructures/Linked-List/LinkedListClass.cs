﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.Linked_List
{

    public class Nodes
    {
        public Nodes NextValue;
        public int value;
    }


    public enum Position { BEGIN,MIDDLE,END}

    public class LinkedList
    {
        public Nodes Head;
        int listCount;

        public void AddItem(int insertValue,Position position,int index = 0)
        {
            Nodes node = new Nodes();
            node.value = insertValue;
            AddtoList(node, position, index);
        }

        public void RemoveItem(Position position, int index = 0)
        {
            RemoveFromList(position, index);
        }
        private void AddtoList(Nodes item, Position addPosition,int index)
        {
            if(Head == null)
            {
                Head = item;
                listCount = 1;
            }
            else
            {
                Nodes tailNode = null;
                if (addPosition == Position.END)
                {
                    for (Nodes node = Head; node != null; node = node.NextValue)
                    {
                        if(node.NextValue == null)
                        {
                            node.NextValue = item;
                            listCount++;
                        }
                    }
                }
                else if(addPosition == Position.BEGIN)
                {
                    var oldHeadItem = Head;
                    var newHead = item;
                    newHead.NextValue = oldHeadItem;
                    Head = newHead;
                    listCount++;
                }
                else if(addPosition == Position.MIDDLE)
                {
                     if(index <= listCount)
                    {
                        int counter = 0;
                        Nodes current = Head;
                        while (current != null)
                        {
                            if(counter + 1 == index)
                            {
                                var movingNode = current.NextValue;
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
                Head = nextItemAfterHead;
                listCount--;
            }
            else if(removePosition == Position.END)
            {
                for (Nodes node = Head; node != null; node = node.NextValue)
                {
                    if (node.NextValue.NextValue == null)
                    {
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
                    Nodes current = Head;
                    while (current != null)
                    {
                        if (counter + 1 == index)
                        {
                            var movingNode = current.NextValue.NextValue;
                            current.NextValue = movingNode;
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
            Nodes current= Head;
            Console.WriteLine("PRINT THE LIST");
            while(current != null)
            {
                Console.WriteLine(current.value);
                current = current.NextValue;
            }
        }
    }
}
