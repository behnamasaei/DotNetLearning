using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Dictionary
    {
        public void Main()
        {
            /// The Dictionary<TKey, TValue> is a generic collection that stores key-value pairs in no particular order.
            /// Dictionary<TKey, TValue> stores key - value pairs.
            /// Comes under System.Collections.Generic namespace.
            /// Implements IDictionary<TKey, TValue> interface.
            /// Keys must be unique and cannot be null.
            /// Values can be null or duplicate.
            /// Values can be accessed by passing associated key in the indexer e.g.myDictionary[key]
            /// Elements are stored as KeyValuePair<TKey, TValue> objects.
            /// It always maintain the order of stored values.


            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
        }
    }
}
