using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            int num = number;

            while (num != 0)
            {
                int rem = num % 10;
                result = result + rem * rem * rem;
                num = num / 10;
            }

            if(result==number)
            {
                Console.WriteLine("It is Armstrong number");
            }
            else
            {
                Console.WriteLine("Not armstrong number");
            }

            Console.Read();

        }
    }
}
