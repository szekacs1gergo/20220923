using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_test
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = rnd.Next(1,10);
            Console.WriteLine(i+" számnak a Fibonacci sorozatban az értéke: {0}",Fibonacc(i));
            Console.ReadLine();
        }
        static int Fibonacc(int n) {
            if (n>1)
            {
                return Fibonacc(n - 1) + Fibonacc(n - 2);
            }
            else
            {
                return n;
            }
            
        }
    }
}
