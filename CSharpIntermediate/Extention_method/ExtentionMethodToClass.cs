using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_method
{
    public class ExtentionMethodToClass
    {
        public void M1() { }
        public void M2() { }
        public void M3() { }

    }

    public static class AddExtention
    {
        public static void M4(this ExtentionMethodToClass ex) { }

        public static void M5(this ExtentionMethodToClass ex, string text) 
        {
            Console.WriteLine(text);
        }
    }
}
