using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{

    delegate int Calaculate(int x, int y);
    // the above delegate can point/references any method
    //that returns an int and takes in two int parameters
    class Program
    {

       
      static int Rect(int x, int y)
        {

            return x * y;
        }
       
        static void Main(string[] args)
        {
            //this progrram show the use of delegate type
            //the program will declare a delegate called "Calculate"
            //calculate can reference point to any method
            //that return an int and take in two int paramerters
           
            
            Calaculate r = Rect; // CAlculate r = new Calculate
            Console.WriteLine("The area is " + r(5, 8));
            Console.ReadKey();
        }
    }
}
