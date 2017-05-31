using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharType
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = 'u';
            char c = 'z';
            char d = '?';
            char e = ' ';
            Console.WriteLine("The Value of a is {0}", a);
            Console.WriteLine("The Value of b is {0} {1}", b,char.IsDigit(b));
            Console.WriteLine("The Value of c is {0} {1}", c, char.IsLower(c));
            Console.WriteLine("The Value of d is {0} {1}", d, char.IsPunctuation(d));
            Console.WriteLine("The Value of e is {0} {1}", e, char.IsWhiteSpace(e));
            Console.ReadKey();
        }
    }
}
