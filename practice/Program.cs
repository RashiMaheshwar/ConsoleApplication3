using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int space = 4;
            int star = 1;
            for (int i = 1; i <=5 ; i++)
            {
               
                for (int k = 1; k <= 9; k++)
                {
                    if ((i == 1 && k == 5) ||
                        (i == 2 && (k == 4 || k == 6)) ||
                        (i == 3 && (k == 3 || k == 7)) ||
                        (i == 4 && (k == 2 || k == 8)) ||
                        i == 5)
                    {
                        Console.Write("*");
                    }
                    else { Console.Write(" "); }
                    
                    
                }
                Console.WriteLine();
            }
          
   
                Console.Read();
        }
    }
}
