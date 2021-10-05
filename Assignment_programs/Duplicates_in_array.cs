using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class Duplicates_in_array
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 20, 60,20, 30, 80,80,80,50, 80 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            Console.WriteLine(arr[i]);
            //        }

            //    }
            //}

            // ORRRRRRRRRRRRRRRRRR
            //List<int> duplicates = new List<int>();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            if(!duplicates.Contains(arr[i]))
            //            duplicates.Add(arr[i]);
            //        }

            //    }
            //}

            //foreach (int n in duplicates)
            //{
            //    Console.WriteLine(n);
            //}

            // ORRRRRRRRRRRRRRR
            //Dictionary<int, int> d = new Dictionary<int, int>();
            //foreach(int number in arr)
            //{
            //    if(d.ContainsKey(number))
            //    {
            //        d[number]++;
            //    }
            //    else
            //    {
            //        d[number] = 1;
            //    }
            //}
            //foreach(var val in d)
            //{
            //    // Console.WriteLine("{0} repeated {1} times",val.Key,val.Value);
            //    Console.WriteLine(val.Key+"   "+val.Value);
            //}
            Hashtable d1 = new Hashtable();
            d1.Add(1, "mani");
            d1[2] = "suma";
            d1[5] = "mangal";
            d1.Add(3, "dinga");
            d1.Add(6, "penga");
            
            
            foreach (var item in d1.Keys)
            {
                Console.WriteLine("{0} {1}",item,d1[item]);
            }
            Console.Read();

            
        }
        
    }
}
