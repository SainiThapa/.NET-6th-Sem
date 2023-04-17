using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisan_2
{
    internal class Program
    {
        /*       static int Add(int x, int y)
               { return x + y;  } */
        static void Main(string[] args)
        {
            List<int> rollno = new List<int>();
            rollno.Add(35);
            rollno.Add(37);
            rollno.Add(38);
            rollno.Add(39);
            rollno.Add(40);
            rollno.Add(41);
            foreach (var item in rollno)
            {
                Console.WriteLine("Roll Num is " + item);
            }
            Console.ReadKey();
        }
    }
           /* Hashtable mylist = new Hashtable();
            mylist.Add("College", "BMC");
            mylist.Add("Contact", 9821914747);
            mylist.Add("ismarried", false);
            foreach (var item in mylist.Keys)
            {
                Console.WriteLine("Key is " + item + " and value is " + mylist[item]);
            }
            Console.ReadKey();*/
    class Indexer
    {
        private string[] names= new string[3];
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
    }
    delegate int Calculate(int x, int y);
            /*ArrayList mylist = new ArrayList();
            mylist.Add("BMC");
            mylist.Add(23264);
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();*/
            //Indexer
/*            Indexer i = new Indexer();
            i[0] = "Suman";
            i[1] = "Saini";
            i[2] = "Tirtha";
            for (int element = 0; element < 3; element++)
            {
                Console.WriteLine(i[element]);
            }
            Console.ReadKey();

            // Partial class
            STM s1 = new STM("Saini", 44);
            s1.display();

            //Delegate
            Calculate calculator = Add;
            int result = calculator(3, 4);
            Console.WriteLine("Sum = " + result);
            Console.ReadKey();*/
           /* //Polymorphism
            Computer c1= new Computer();
            Consolegame c2= new Consolegame();
            Mobile c3 = new Mobile();
            c1.Model_name();
            c2.Model_name();
            c3.Model_name();

            ////abstraction
            Class_obj c4 = new Computer();
            c4.price();
            c4.Model_name();

            //Interface in c#
            c2.Model_name();
            c2.Manufacturer();
*/
}
