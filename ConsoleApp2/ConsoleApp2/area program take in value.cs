using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, w, a;
           // l = 50;
            Console.WriteLine("pleasr type in any length");
            l = Convert.ToInt16(Console.ReadLine());
            w = 10;
            a = l * w;

            Console.WriteLine("the length is {0}, the width is {1}, the area is {2}", l, w, a);
            Console.WriteLine("The length is" + l + "the width is" + w + "the area is" + a);
            Console.ReadKey();

        }
    }
}
