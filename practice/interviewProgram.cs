using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class interviewProgram
    {


        class Employee
        {
            public string name;
            public int exp;
           public int id;
            public int sal;
           public int count = 1;
        }
        class permanentEmployee:Employee
        {
           
            public permanentEmployee(string name, int exp)
                {
                this.name = name;
                this.id = count;
                count++;
                if (exp <= 2)
                {
                    sal = 20000;
                }
                else if (exp < 5)
                {
                    sal = 30000;
                }
                else
                {
                    sal = 40000;
                }
                
                }


        }

        class contractEmployee : Employee
        {
            public contractEmployee(string name,int exp)
            {
                this.name = name;
                this.id = count;
                count++;
                if (exp <= 2)
                {
                    sal = 15000;
                }
                else if (exp < 5)
                {
                    sal = 25000;
                }
                else
                {
                    sal = 35000;
                }

            }

        }
        
        static void Main(string[] args)
        {
            List<Employee> emps=new List<Employee>();
            int no = 1;
            while (no == 1)
            {
                Console.WriteLine("enter name ");
                string name = Console.ReadLine();
                Console.WriteLine("enter type ");
                string type = Console.ReadLine();
                Console.WriteLine("enter exp");
                int exp = int.Parse(Console.ReadLine());

                if (type == "permanent")
                {
                    emps.Add(new permanentEmployee(name, exp));
                }
                else
                {
                    emps.Add(new contractEmployee(name, exp));
                }
                Console.WriteLine("if u want to add another employee enter1 or enter 2");
                no = int.Parse(Console.ReadLine());
            }
            foreach (var item in emps)
            {
                Console.WriteLine("name="+item.name+" id="+item.id+" sal="+item.sal);
            }
            Console.ReadLine();


        }
    }
}
