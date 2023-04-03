using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();
            Hashtable ht= new Hashtable();
            ht.Add("44", "Saini");
            ht.Add("58", "Sushil");
            ht.Add("36", "Kumpa");
            ICollection key= ht.Keys;

            foreach(string k in key)
            {
                Console.WriteLine(k + " : "+ ht[k]);
            }
            Console.ReadKey();

            Console.WriteLine("adding some details");
            mylist.Add("BMC");
            mylist.Add("College");
            mylist.Add("071523421");
            mylist.Add(true);

            Console.WriteLine($"Contains 1 : {mylist.Contains(1)}");
            Console.WriteLine("Capacity : " + mylist.Capacity);
            for (int i = 0; i < mylist.Capacity; i++)
            {
                Console.WriteLine(mylist[i]);
            }
            Console.ReadKey();
        }
    }
}
