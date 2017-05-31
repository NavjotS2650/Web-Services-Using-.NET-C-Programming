using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
          //  int l = null;
           // bool k = null;
           // int l = 17;
          //  bool k = true;

            int? length = null;
            bool? k = null;
            Console.WriteLine("The value of 1 is {0}, and k is {1}", length, k);

            length = 5;
            k = true;

            if (k != null)
            {
                Console.WriteLine("The value of 1 is {0}, and k is {1}", length, k);
            }

            
            Console.ReadKey();
        }
    }
}
