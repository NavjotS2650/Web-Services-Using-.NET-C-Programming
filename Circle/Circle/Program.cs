using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            double r;
            Console.WriteLine("Enter the radius of Circle");
            r = Convert.ToDouble(Console.ReadLine());
            calculateArea(r);
            Console.ReadKey();


        }



        static void calculateArea(double r)
        {
            Console.WriteLine("The area of the Circle {0}",Math.PI*r*r);
        }
    }
}
