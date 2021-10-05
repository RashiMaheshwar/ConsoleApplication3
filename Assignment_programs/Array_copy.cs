using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class Array_copy
    {
        static void Main(string[] args)
        {
            int[] ar1 = { 2, 4, 6, 8 };
            int[] ar2 = new int[ar1.Length];
            //for (int i = 0; i <ar1.Length; i++)
            //{
            //    ar2[i] = ar1[i];
            //}

            //for (int i = 0; i < ar1.Length; i++)
            //{
            //    Console.WriteLine(ar2[i]);
            //}

            // ***USING COPY TO METHOD*******
            //ar1.CopyTo(ar2, 0);
            //ar2[1]++;
            //for (int i = 0; i < ar1.Length; i++)
            //{
            //    Console.WriteLine(ar2[i]);
            //}

            //********************using clone method*****
            ar2 = (int[])ar1.Clone();
            for (int i = 0; i < ar1.Length; i++)
            {
                Console.WriteLine(ar2[i]);
            }

            Console.Read();
        }
    }
}
