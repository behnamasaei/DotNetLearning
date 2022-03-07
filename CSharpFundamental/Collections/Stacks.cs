using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Stacks
    {
        public void Main()
        {
            /// Stack
            /// Stack is a special type of collection that stores elements in LIFO style (Last In First Out).
            /// Stack is useful to store temporary data in LIFO style, and you might want to delete an element after retrieving its value.
            /// Elements can be added using the Push() method. Cannot use collection-initializer syntax.
            /// Elements can be retrieved using the Pop() and the Peek() methods. It does not support an indexer.
            /// 

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);

            myStack.Contains(2); // returns true
        }
    }
}
