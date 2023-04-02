using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisan_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer c1= new Computer();
            Consolegame c2= new Consolegame();
            Mobile c3 = new Mobile();
            c1.Model_name();
            c2.Model_name();
            c3.Model_name();
            Class_obj c4 = new Computer();
            c4.price();
            c4.Model_name();

        }
    }
}
