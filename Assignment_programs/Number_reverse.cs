using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class Number_reverse
    {
        static void Main(string[] args)
        {
            int number = 12345;
            int rev = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                rev = rev * 10 + remainder;
                number = number / 10;

            }
            Console.WriteLine(rev);
            Console.Read();

           
        }
    }
}
