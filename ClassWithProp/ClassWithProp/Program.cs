using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonWithProp
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Age = 25;
            p.Name = "Batman";
            Console.WriteLine(p.Age + p.Name);
            Console.ReadKey();
        }
    }
}
