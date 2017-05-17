using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankcharge
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 50;
            int count = 0;
            Console.WriteLine("the balanced owed ${0}", balance);
            while(balance<=100)
            {
                balance = balance + (balance * 0.02);              
            Console.WriteLine("the months are {0} ", balance);
                Console.ReadKey();

            }
        }
    }
}
