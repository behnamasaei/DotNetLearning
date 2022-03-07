using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class FirstClass
    {
        protected string Name { get; set; }
        protected string Description { get; set; }

        protected void PrintMessage()
        {
            Console.WriteLine($"Hello {Name}");
        }
    }


    public class Inheritance : FirstClass
    {
        
    }
}
