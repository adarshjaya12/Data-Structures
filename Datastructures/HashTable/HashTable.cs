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

        public void PrintAllHash()
        {
            Console.WriteLine("Printing All Hash");
            for(int i = 0; i < Size; i++)
            {
                var result = KeyValuePairs[i];
                if(result != null && result.Count > 0)
                {
                    Console.WriteLine("\nIndex count: {0}", i);
                    foreach (var item in result)
                    {
                        Console.WriteLine("Key is {0} and the Value is {1}", item.Key, item.Value);
                    }
                    Console.WriteLine("End of Index count: {0}\n", i);
                }
            }
        }

        public void Add(K key,V value)
        {
            var indexByKey = GetIndexByKey(key);
            var result = KeyValuePairs[indexByKey];
            if (result == null)
            {
                LinkedList<KeyValuePair<K, V>> firstList = new LinkedList<KeyValuePair<K, V>>();
                var firstValue = new KeyValuePair<K, V>();
                firstValue.Key = key;
                firstValue.Value = value;
                firstList.AddFirst(firstValue);
                KeyValuePairs[indexByKey] = firstList;
            }
            else
            {
                result.AddFirst(new KeyValuePair<K, V>() { Key = key, Value = value });
                KeyValuePairs[indexByKey] = result;
            }
        }


        public void Remove(K key)
        {
            var indexByKey = GetIndexByKey(key);
            var result = KeyValuePairs[indexByKey];
            if(result != null)
            {
                if(result.Count == 1)
                {
                    result.RemoveFirst();
                }
                else
                {
                    KeyValuePair<K, V> itemToRemove = null;
                    foreach(var item in result)
                    {
                        if(item.Key.GetHashCode() == key.GetHashCode())
                        {
                            itemToRemove = item;
                        }
                    }
                    if(itemToRemove != null)
                        result.Remove(itemToRemove);
                }
            }
        }

        public int GetIndexByKey(K key)
        {
            return Math.Abs(key.GetHashCode() % Size);
        }
        
    }
}
