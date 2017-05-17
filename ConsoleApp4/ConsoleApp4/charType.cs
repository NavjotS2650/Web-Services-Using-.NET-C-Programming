using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = '1';
            char c = 'z';
            char d = '?';
            char e = ' ';
            Console.WriteLine("the value of a is {0}", a);
            Console.WriteLine("the value of b is {0}.it is a digit     {1}", b, char.IsDigit(b));
            Console.WriteLine("the value of c is {0}.it is a lowercase {1}", c, char.IsLower(c));
            Console.WriteLine("the value of d is {0},it is punctuation {1}", d, char.IsPunctuation(d));
            Console.WriteLine("the value of e is {0}.it is whitespace  {1}", e, char.IsWhiteSpace(e));
            Console.ReadKey();


        }
    }
}
