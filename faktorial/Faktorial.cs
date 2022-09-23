using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = rnd.Next(1,10);
            Console.WriteLine(i+"-nek a faktoriális értéke: {0}",Faktorialis(i));
            Console.ReadLine();
        }
        static int Faktorialis(int n) {
            if (n>0)
            {
                return n * Faktorialis(n - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
