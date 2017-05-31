using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{


    delegate int funcdelegate(int n, int m);
    class Delegate_2
    {
        public static int addNUm(int m, int n)
        {
            return m + n;
        }

        public static int mulNUm(int m, int n)
        {
            return m * n;
        }


        static void main(String[] args)
        {

            funcdelegate d1 = addNUm;
            funcdelegate d2 = mulNUm;
            Console.WriteLine(d1(4,5));
            Console.WriteLine(d2(4, 5));
        }


        // this example will show a delegate points two methods

    }
}
