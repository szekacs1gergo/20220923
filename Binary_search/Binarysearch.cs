using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Binary_search
{
    class Binary
    {
        static void Main(string[] args)
        {
            int[] a = { 200, 40, -80, 89, 30, 60 };
            Random rnd = new Random();
            int n = rnd.Next();
            int iguess = Binaryserch(a, a.Length - 1, n);
            foreach (var item in a)
            {
                Console.WriteLine(item);
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(iguess);
            Console.ReadKey();
        }
        static int Binaryserch(int[] a,int n, int searched) {

            int left = 0;
            int right = n - 1;
            for (int middle = (left+right); left <= right; middle=(left+right)/2)
            {
                if (a[middle]==searched)
                {
                    return middle;
                }
                else
                {
                    if (searched <a[middle])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
            }
            return -1;
        }
    }
}
