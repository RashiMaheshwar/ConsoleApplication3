using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class String_reverse
    {
        static void Main(string[] args)
        {
            string s1 = "abcdef";
            string s2 = null;
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                s2 = s2 + s1[i];
            }

            Console.WriteLine(s2);
            Console.Read();



        }
    }
}
