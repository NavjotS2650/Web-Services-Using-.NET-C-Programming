using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedDelegates
{ 

    delegate void functionDelegate(int x, int y);
    class Program
    {


        public static void addNum(int y, int x)
        {
            Console.WriteLine("the sum is" + (x + y));
        }

        public static void mulNum(int y, int x)
        {
            Console.WriteLine("the mul is" + (x * y));
        }
        static void Main(string[] args)
        {
            functionDelegate d1 = addNum;
            functionDelegate d2 = mulNum;

            functionDelegate d3 = d1 + d2;
            d3(4, 5);
            Console.ReadKey();
        }
    }
}
