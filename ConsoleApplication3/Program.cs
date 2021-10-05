using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        class employee
        {
           public int experience;
            public string employeeType;
            public int salary;
            public string name;
            public employee(string name, int exp, string Type,)
            {
                this.name = name;
                experience = exp;
                employeeType = Type;

                if (Type == "permanent")
                {

                    if (exp <= 2)
                    {
                        this.salary = 200000;
                    }
                    else if (exp > 2)
                    {
                        if (exp < 5)
                        {
                            this.salary = 300000;
                        }
                        else {
                            this.salary = 40000;
                        }
                    }
                }


                if (Type == "contract")
                {

                    if (exp <= 2)
                    {
                        this.salary = 150000;
                    }
                    else if (exp > 2)
                    {
                        if (exp < 5)
                        {
                            this.salary = 300000;
                        }
                        else
                        {
                            this.salary = 40000;
                        }
                    }
                }

            }

        }


        static void Main(string[] args)
        {

            employee[] emp = {new employee(2,"permanent",200000),new employee() }
        }
    }
}
