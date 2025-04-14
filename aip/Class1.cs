using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aip
{
    //вариант 21
    public class Class1
    {
        //по заданному номеру месяца получить название следующего за ним месяца
        public static string Z1(int a)
        {
            string[] month = new string[] {"январь","февраль","март","апрель","май","июнь","июль","август","сентябрь","октябрь","ноябрь","декабрь"};
            if (a==12)
            {
                return month[0];
            }
            if (a>12)
            {
                return "error";
            }
            return month[a];
        }

        //система вырожений
        public static double Z2(double a)
        {
            double rez = 0;
            if (a<0)
            {
                rez=(Math.Log(a*a)+Math.Sin(a))/(a+1);
                return rez;
            }
            double z = 0;
            z = Convert.ToDouble(Console.ReadLine());
            if (a < 6)
            {
                rez = (Math.Sqrt(z+a)-Math.Cos(a)* Math.Cos(a))/Math.Abs(z+a);
                return rez;
            }
            if (a >= 6)
            {
                rez = 10 / a + Math.Exp(a - z);
                return rez;
            }
            return 0;
        }
    }
}
