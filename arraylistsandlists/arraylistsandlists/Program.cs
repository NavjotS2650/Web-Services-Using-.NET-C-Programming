using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylistsandlists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("danny");
            al.Add("gur");
            al.Add(5);
            al.Add(20);


            List<string> list1 = new List<string>();
            list1.Add("gur");
            list1.Add(12);
        }
    }
}
