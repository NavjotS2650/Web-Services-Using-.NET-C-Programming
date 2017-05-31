using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizQuestion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the room Capacity");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the People Attending");
            int a = Convert.ToInt32(Console.ReadLine());


            if (a <= c)
            {
               
                int suggest;
                suggest = c - a;
                Console.WriteLine("It is Legal to attend the Room.\n Additional People can attend {0}",suggest);
               
            }
            else
            {
                int suggest;
                suggest = a-c;
                Console.WriteLine("Meeting can not be held as Planned Due to fire Regulation.\n Amount Additional People Exclude {0}", suggest);
            }

            Console.ReadLine();
        }
    }
}
