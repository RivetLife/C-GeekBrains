using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulThings
{
    public class Useful
    {
        public static void Pause()
        {
            Console.ReadKey();
        }

        public static int Min(int a, int b, int c)
        {
            int min = a;

            if (b < min)
            {
                min = b;
            }

            if (c < min)
            {
                min = c;
            }

            return min;
        }

        public static double IMT(double height, double weight)
        {
            double imt = weight / (height * height);
            Console.WriteLine("Ваш индекс массы тела (ИМТ) равен {0:F2}.", imt);
            return imt;
        }

        public static int NumbSumm(int number)
        {
            int sum = 0;
            string numb = Convert.ToString(number);

            for(int i = 0; i < numb.Length; i++)
            {
                sum += Convert.ToInt32(numb.Substring(i, 1));
            }

            return sum;
        }
    }
}
