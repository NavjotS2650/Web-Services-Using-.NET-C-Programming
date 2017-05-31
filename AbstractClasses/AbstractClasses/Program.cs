using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p = new Person();
            p.personsays();
            p.doSuff1();
            p.doSuff2();
            p.doStuff3();


            Console.ReadKey();

        }
    }
}
