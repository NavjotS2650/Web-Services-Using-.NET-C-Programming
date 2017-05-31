using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesApplicationWeek2
{
    class Lines
    {
        static void Main(string[] args)
        {







            Console.WriteLine("Enter the Coordinates X1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Coordinates Y1");
            double y1 = Convert.ToDouble(Console.ReadLine());


             Console.WriteLine("Enter the Coordinates X2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Coordinates Y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter the Coordinates X3");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Coordinates Y3");
            double y3 = Convert.ToDouble(Console.ReadLine());


            if((x2-x1)*(y3-y1)-(x3-x1)*(y2-y1)>0){

                Console.WriteLine("The line ON left");
                


            }else if((x2-x1)*(y3-y1)-(x3-x1)*(y2-y1)==0){


                 Console.WriteLine("The line ON Same");

            }else{


                 Console.WriteLine("The line ON Right");

            }



            Console.ReadKey();














            }



        }
    }

