using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Person:Abstract1,Interface1,Interface2
    {


        public override void personsays()
        {
            Console.WriteLine("I am a person");

        }

        public void doStuff1()
        {
            Console.WriteLine("I am a doStuff1");

        }

        public void doStuff2()
        {
            Console.WriteLine("I am a doStuff2");

        }

        public void doStuff3()
        {
            Console.WriteLine("I am a doStuff3");

        }
    }
}
