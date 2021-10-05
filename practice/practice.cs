using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class practice
    {

        static void Main(string[] args)
        {
            /* Stack s = new Stack();
             s.Push(1);
                 s.Push(2);
             s.Push(3);
             s.Push(4);
             s.Push(5);
             s.Push(6);
                          s.Push(7);*/
            Queue q1 = new Queue();


            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if(i==j||i+j==4)
                    {
                        Console.Write("*");
                    }
                    else { Console.Write(" " ); }

                }
                Console.WriteLine();

                
            }
            Console.Read();

        }
    }
}
