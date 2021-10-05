using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            //for (int i = num; i >=1; i--)
            //{
            //    fact = fact * i;
            //}

            find_fact(num, fact);
            
          
            Console.ReadLine();
        }

        public static void find_fact(int num,int fact)
        {
            fact = fact * num;
            num--;
            if (num > 0)
            {
                find_fact(num, fact);
            }
            else
            {
                Console.WriteLine(fact);
            }
        }
    }
}
