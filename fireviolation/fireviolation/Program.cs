using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
d
namespace fireviolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the total capacity of room is");
            int maxcap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the people attending the class");
            int people = Convert.ToInt32(Console.ReadLine());
            
            if(people<=maxcap)
            {
                int can = maxcap - people;
                Console.WriteLine("it is legal to attend the meeting, the people room can have is {0}", can);
            }

            if(maxcap<people)
            {
                int cannot = people - maxcap;
                Console.WriteLine("the room limit is exceeded and the people need to get lost are this much {0}", cannot);
            }
            Console.ReadKey();
        }
    }
}
