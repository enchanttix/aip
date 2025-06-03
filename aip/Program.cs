using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //string month = aip.Class1.Z1(a);
            //Console.WriteLine(month);
            //double a1 = Convert.ToDouble(Console.ReadLine());
            //double rez = Class1.Z2(a1);
            //Console.WriteLine(rez);
            //Console.ReadLine();

            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = aip.Class2.Arr(a);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(Class2.zz(arr));
            Console.ReadLine();
        }
    }
}
