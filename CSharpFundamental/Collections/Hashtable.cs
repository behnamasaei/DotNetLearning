using System.Collections;

namespace Collection;

public class Hashtables
{
    public void Main()
    {
        /// Hashtable
        /// The Hashtable is a non-generic collection that stores key-value pairs
        /// Comes under System.Collection namespace.
        /// Keys must be unique and cannot be null.
        /// Values can be null or duplicate.
        /// Elements are stored as DictionaryEntry objects.
        /// The data retrieval is slower than Dictionary due to boxing/ unboxing.
        /// It is thread safe.	
        /// It doesn’t maintain the order of stored values.
        /// 

        // Create a hashtable
        // Using Hashtable class
        Hashtable numberNames = new Hashtable();

        // Adding key/value pair in the hashtable
        // Using Add() method
        numberNames.Add(1, "One"); //adding a key/value using the Add() method
        numberNames.Add(2, "Two");
        numberNames.Add(3, "Three");
    }

}

