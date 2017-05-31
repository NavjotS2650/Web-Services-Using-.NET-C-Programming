using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultitaskDelegates
{    
    delegate int funcdelegate(int n, int m);
    class Program
    {

        public static int addNUm(int m, int n)
        {
            return m + n;
        }

        public static int mulNUm(int m, int n)
        {
            return m * n;
        }


        static void Main(string[] args)
        {
            //a multi cast delegates can point to more than one 
            //delegate 
            // all delegates have multi cast capabilities.
            // a delegate can point to list of method by providing differenet variable

            // use += operator to add method to a delegate
            //list.
            // Methods are invoked int the orderr they added
            // to remove a mothod from the list user -= operator.

            funcdelegate d1 = addNUm;
            d1 += mulNUm;
            Console.WriteLine("THE FIRST ONe" + d1(5, 6));
            d1 -= addNUm;
            Console.WriteLine("THe addition of 10 and 20 is"+d1(5,6));
            if (d1 == null)
            {
                Console.WriteLine("Delegate of the methods");
            }
            Console.ReadLine();


        }
    }
}
