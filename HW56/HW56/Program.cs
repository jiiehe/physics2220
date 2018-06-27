using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW56
{
    class Program
    {
        //question2 link: https://www.chegg.com/homework-help/questions-and-answers/electron-velocity-180-km-s-positive-x-direction-acceleration-200-1012-m-s2-positive-z-dire-q21371767?trackid=77a5d669&strackid=357b61bf&ii=8



        static void Main(string[] args)
        {
            question65();
        }

        public static void question63()
        {
            double g = 9.8;
            double r0 = 0.0400;
            double B = 3.10;
            double I = r0 * g / B;
            Console.WriteLine(I);
            Console.Read();
        }

        /// <summary>
        /// https://www.hudson.k12.oh.us/cms/lib08/OH01914911/Centricity/Domain/402/Chap%2029%20group%202.pdf
        /// </summary>
        public static void question64()
        {
            double m = 0.1;
            double g = 9.8;
            double L = 4.00;
            double a = 0.1;
            double I = 3.0;
            double B = 0.0200;
            double N = L / (4.0 * a);
            double A = Math.Atan(B*I*L/2*m * g);
            double final =180/(Math.PI/A);

            double temp=Math.Cos(Math.PI / (180 / 6.86));
            Console.WriteLine(temp);
            Console.WriteLine(final);
            double final1 = (0.25) * I * L * B * a * temp;
            Console.WriteLine(final1);
            Console.Read();
        }
        /// <summary>
        /// https://www.chegg.com/homework-help/questions-and-answers/singly-charged-positive-ion-mass-250-10-26-kg-accelerated-potential-difference-250v-ion-en-q1186125
        /// </summary>
        public static void question65()
        {
            double m = 3.2 * Math.Pow(10, -26);
            double V = 828.0;
            double B = 0.820;
            double q = 2.5 * Math.Pow(10, -26);
            double deltaV = 1.6 * Math.Pow(10, -19);
            double v = Math.Sqrt(2 * V* deltaV / m);
            Console.WriteLine(v);
            double r = m * v / deltaV * B;
            Console.WriteLine(r);
            Console.Read();
        }
    }
}
