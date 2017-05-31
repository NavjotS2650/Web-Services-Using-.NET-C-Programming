using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 50;
            int counter = 0;
            while (balance < 100)
            {
                
                balance =balance + (2/100.0 * balance);
                counter++;
            }

            Console.WriteLine("THe months are {0}", counter);
            Console.ReadLine();

        }
    }
}
