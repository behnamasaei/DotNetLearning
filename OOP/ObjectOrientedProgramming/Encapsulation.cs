using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming;
                          
public class Encapsulation
{
    /// Encapsulation, in the context of C#, refers to 
    /// an object's ability to hide data and behavior that are not necessary to its user.
    /// Encapsulation enables a group of properties,
    /// methods and other members to be considered a single unit or object.
    /// --------
    /// benefits 
    /// Protection of data from accidental corruption
    /// Specification of the accessibility of each of the members of a class to the code outside the class
    /// Flexibility and extensibility of the code and reduction in complexity
    /// Lower coupling between objects and hence improvement in code maintainability



    private string _studentName;
    private int _studentAge;

    public string Name
    {
        get { return _studentName; }
        set { _studentName = value; }
    }

    public int Age
    {
        get { return _studentAge; }
        set { _studentAge = value; }
    }
}

