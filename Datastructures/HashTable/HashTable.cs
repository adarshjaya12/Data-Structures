using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures.HashTable
{
    public class KeyValuePair<K,V>
    {
        public K Key;
        public V Value;
    }

    public class HashTable<K, V>
    {
        LinkedList<KeyValuePair<K, V>>[] KeyValuePairs;
        int Size = 0;
        public HashTable(int size)
        {
            Size = size;
            KeyValuePairs = new LinkedList<KeyValuePair<K, V>>[Size];
        }


        public void Add()
        {

        }


        public int GetIndexByKey(K key)
        {
            return key.GetHashCode() % Size;
        }
        
    }
}
