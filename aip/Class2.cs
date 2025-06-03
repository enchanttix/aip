using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aip
{
    public class Class2
    {
        public static int[] Arr(int i)
        {
            Random rnd = new Random();
            int[] arr = new int[i];
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = rnd.Next(10);
            }
            return arr;
        }

        public static string zz(int[] arr)
        {
            int sum=0;
            int ind = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    sum += arr[i];
                }
                else
                {
                    ind++;
                }
            }
            return "сумма четных элементов = " + sum + " количество нечетных элементов = " + ind;
        }
    }
}
