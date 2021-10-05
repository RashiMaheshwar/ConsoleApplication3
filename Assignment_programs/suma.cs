using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_programs
{
    class suma
    {
        static void Main(string[] args)
        {
            mahesh m = new mahesh();
            m.name = "malli";
            Console.WriteLine(m.name);
            changename(m);
            Console.WriteLine(m.name);
            Console.Read();
        }
        static void changename(mahesh m)
        {
            m.name = "suma";
        }
    }
    class mahesh
    {
       public string name;
    }
}
