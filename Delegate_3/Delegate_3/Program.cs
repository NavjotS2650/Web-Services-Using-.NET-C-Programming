using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_3
{


    delegate int funcDelegate(int m,int n);
    delegate int funcDelegate2(int m, int n);
    class Program
    {
        public static int addNum(int m, int n)
        {
            return m + n;
        }

        public static int mulNum(int m, int n)
        {
            return m * n;
        }
       
        
        
        static void Main(string[] args)
        {
            funcDelegate d1 = addNum;
            funcDelegate d2 = addNum;

            if (d1 == d2)
            {

                Console.WriteLine("They are equal");
                Console.ReadLine();
            }



        }
    }
}
