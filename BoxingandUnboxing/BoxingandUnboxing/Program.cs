using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingandUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * has Value types and reference types
             * Values Types you can store values directly
             * Reference types dont store values but they store references of the objects
             * convert a value to reference type(boxing)
             * convert a reference type to value types (unboxing);
             */
            int l = 5;
            Object obj = l;
            int x = (int)obj;

            // boxing and unboxing -> computationally expensive
            //Boxing a new object creates more space
            //unboxing casting a computation is expensive

        }
    }
}
