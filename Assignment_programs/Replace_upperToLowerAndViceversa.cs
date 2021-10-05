using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class Replace_upperToLowerAndViceversa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word");
            string s1 = Console.ReadLine();
            string s2 = "";
            for(int i=0;i<s1.Length;i++)
            {
                char ch = s1.ElementAt(i);
                if(char.IsUpper(ch))
                {
                   ch= char.ToLower(ch);
                }
                else
                {
                   ch=char.ToUpper(ch);
                }
                s2 = s2 + ch;
            }
            Console.WriteLine("after replacing");
            Console.WriteLine(s2);
            Console.Read();
        }
    }
}
