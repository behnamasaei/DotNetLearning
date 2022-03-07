using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class SortedList
    {
        public void Main()
        {
            /// SortedList<TKey, TValue> is an array of key-value pairs sorted by keys.
            /// Sorts elements as soon as they are added.
            /// Comes under System.Collection.Generic namespace.
            /// A key must be unique and cannot be null.
            /// A value can be null or duplicate.
            /// A value can be accessed by passing associated key in the indexer mySortedList[key]
            /// It uses less memory than SortedDictionary<TKey,TValue>.
            /// It is faster in the retrieval of data once sorted, whereas SortedDictionary<TKey, TValue> is faster in insertion and removing key-value pairs.

            //SortedList of int keys, string values 
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);

            foreach (var item in numberNames)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            // Output:
            // 1 - One
            // 2 - Two
            // 3 - Three
            // 4 -
        }
    }
}
