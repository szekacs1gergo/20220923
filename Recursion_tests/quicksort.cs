using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Recursion_tests
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            
            //tömb létrehozása & egyéb
            int[] a = {200,40,-80,89,30,60};
            Quick_Sort(a,0,a.Length-1);
        }
        static void Quick_Sort(int[] a, int LowerIndex, int higherIndex)
        {
            //értékfelvétel
            int i = LowerIndex;
            int j = higherIndex;
            int pivot = a[LowerIndex + (higherIndex - LowerIndex) / 2];
            //amíg nem nagyobb addig csinálja
            while (i <= j)
            {
                //ha kisebb az [i] mint a pivot akkor i+1
                while (a[i]<pivot) {i++;}
                //amíg nagyobb a [j] mint a pivot akkor j-1
                while (a[j] > pivot) {j--;}
                //ha kisebb vagy egyenlő az [i] a j-vel akkor
                if (i<=j)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] =temp;
                    i++;
                    j--;
                }
            }
            //ha a LowerIndex kisebb mint a j
            if (LowerIndex<j)
            {
                Quick_Sort(a,LowerIndex, j);
            }
            //ha a i kisebb mint a higherIndex
            if (i < higherIndex)
            {
                Quick_Sort(a, i, higherIndex);
            }
            //amíg az item a tömb elemein fut addig írja ki az item+" "-t
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
