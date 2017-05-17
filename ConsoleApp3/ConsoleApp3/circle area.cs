using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the radius of the circle");
            double r = Convert.ToDouble(Console.ReadLine());
            calculateArea(r);

        }
        static void calculateArea( double r)
        {
            Console.WriteLine("the area is {0}", Math.PI * r * r);
            Console.ReadKey();
        }
    }
}
