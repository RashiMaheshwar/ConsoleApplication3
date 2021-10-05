using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class ReverseArray
    {
        static void Main(string[] atgs)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] revArr = new int[arr.Length];
            //int index = 0;
            //for(int i=arr.Length-1;i>=0;i--)
            //{
            //    revArr[index] = arr[i];
            //    index++;
            //} 

            //for(int i=0;i<revArr.Length;i++)
            //{
            //    Console.WriteLine(revArr[i]);
            //}
            //Console.Read();
            int start = 0;
            int end = arr.Length - 1;
            while (start<end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }
            Console.Read();

        }
    }
}
