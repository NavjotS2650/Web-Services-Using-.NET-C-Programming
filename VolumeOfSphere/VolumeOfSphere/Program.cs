using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfSphere
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program p = new Program();
            Console.WriteLine("Enter the Radius of sphere:");
            Console.WriteLine("THe volume is:" + p.calculate(Convert.ToDouble(Console.ReadLine()))
                );


            Console.ReadLine();
        }

        double calculate(double e)
        {
           
            
            e = e * (4 / 3.0) * Math.PI * e * e;


            return e;
        }




    }
}
