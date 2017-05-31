using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int l, w, a;

            //l = 50;
            Console.WriteLine("Please type in the length");
            l = Convert.ToInt32(Console.ReadLine());
           // w = 10;
            Console.WriteLine("Please type in the Width");
            w = Convert.ToInt32(Console.ReadLine());
            a = l * w;

            Console.WriteLine("The area of Rectangle is {0}, The area is {1}, The lenght is{2}", a,w,l);




            //System.out.print("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Sat Shri Akal ji");
            Console.ReadKey();
        }
    }
}
