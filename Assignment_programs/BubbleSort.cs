using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 90, 20, 80, 30, 40, 70, 5 };
            Console.WriteLine("before sorting");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

                for (int i = 0; i <arr.Length; i++)
            {
                for(int j=0;j<arr.Length-1;j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
            Console.WriteLine("After sorting");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Read();
            
            

        }
    }
}
