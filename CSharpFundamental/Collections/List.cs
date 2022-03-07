using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections;

internal class List
{
    public void Lists()
    {
        /// Creating List
        /// 
        // method 1
        List<int> phoneNumbers = new List<int>();
        phoneNumbers.Add(1); // Adding elements
        // method 2
        List<string> name = new List<string>()
        {
            "Behnam" , "Asaei" , "Bob" , "John"
        };

        // adding Array to List
        int[] age = new int[] { 1, 2, 3 };
        List<int> studentAge = new List<int>();
        studentAge.AddRange(age);


        /// Insert in List 
        phoneNumbers.Insert(0, 1); // insert 1 at 0st index

        /// Romove from List
        phoneNumbers.Remove(0);  // remove first 0 value from list
        phoneNumbers.RemoveAt(0);  // remove value of 0st index
    }



}
