using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    // Define a class to represent key-value pairs for the hash table
    public class MyMapNode<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

    }
}
