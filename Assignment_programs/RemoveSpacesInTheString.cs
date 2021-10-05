using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class RemoveSpacesInTheString
    {
        static void Main(string[] args)
        {
            string s1 = "I love my country";
            string s2 = "";
            //for(int i=0;i<s1.Length;i++)
            //{
            //    if(!char.IsWhiteSpace(s1[i]))
            //    {
            //        s2 = s2 + s1[i];
            //    }

            //}
           // Console.WriteLine(s2);

            for(int i=0;i<s1.Length-1;i++)
            {
                if(char.IsWhiteSpace(s1[i]))
                {
                    s1 = s1.Remove(i, 1);
                }
            }
            Console.WriteLine(s1);
            Console.Read();
           
        }
    }
}
