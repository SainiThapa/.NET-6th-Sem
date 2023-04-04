using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Const_dest
    {
        public Const_dest() {
            Console.WriteLine("Default constructor is called");

        }
        public Const_dest(int x)
        {
            Console.WriteLine(" Parameterized Constructor is called");
        }
        ~Const_dest()
        {
            Console.WriteLine("Destructor is called");
            Console.ReadKey();
        }
    }

}
