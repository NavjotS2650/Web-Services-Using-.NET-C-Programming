using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2PartBExams
{
    class Program
    {
        static double[] test = new double[4];
        static float[] assign = new float[5];
        static double exam;
        static double a;
        static double t;
        static double sa;
        static double st;

        static double average()
        {
            if (test[0] != null)
            {
                t = test.Average();

            }


            if (assign[0] != null)
            {
                a = assign.Average();


            }

            return 0;
        }

        static double standardev(double avg, double avg1)
        {
            double sumofDev = 0;
            foreach (double value in test)
            {
                sumofDev += (value) * (value);
            }

            double sumofDevA = sumofDev / 4;
            st = Math.Sqrt(sumofDevA-(avg*avg));

            double sumofDev2 = 0;
            foreach (double value in assign)
            {
                sumofDev2 += (value) * (value);
            }

            double sumofDevA1 = sumofDev2 / 4;
            sa = Math.Sqrt(sumofDevA1 - (avg1 * avg1));
            
            return 0;

        }





        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the marks for Test " + i + 1);
                test[i] = Convert.ToDouble(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the marks for Assignment " + i + 1);
                assign[i] = float.Parse(Console.ReadLine());

            }
            Console.WriteLine("Enter the marks for Exam ");
            exam = Convert.ToDouble(Console.ReadLine());




            double sumT = 0; ;
            for (int i = 0; i < 4; i++)
            {
                sumT += test[i];
            }

            double assT = 0; ;
            for (int i = 0; i < 5; i++)
            {
                assT += assign[i];
            }



            double avgT = average();
           
            double avgA = average();
            double standA = standardev(t,a);




            double total = a * 0.40 + t * 0.15 + exam * 0.45;

            Console.WriteLine("Enter the marks for Assignment " + total);

            Console.WriteLine("Average is Test Equal to " + t);
            Console.WriteLine("StandDev is Test  Equal to " + st);

            Console.WriteLine("Average is Assignment Equal to " + a);
            Console.WriteLine("StandDev is Assignment Equal to " +sa);

            //references http://www.dotnetspider.com/forum/325125-Average-Test-Score-c.aspx
            if (total >= 80 && total <= 100)
                Console.WriteLine(" A - \"Excellent\"");
            else if (total >= 70 && total <= 79)
                Console.WriteLine(" B - \"Good\"");
            else if (total >= 60 && total <= 69)
                Console.WriteLine(" C - \"Fair\"");
            else if (total >= 50 && total <= 59)
                Console.WriteLine(" D - \"Poor\"");
            else
                Console.WriteLine("F - \"Fail\"");









            Console.ReadKey();




        }
    }
}
