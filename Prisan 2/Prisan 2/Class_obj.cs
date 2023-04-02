using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisan_2
{
    abstract class Class_obj
    {
        public abstract void Model_name();
        public void price()
        {
            Console.WriteLine("Rs. 170000");
        }

    }
    class Computer:Class_obj
    {
        public override void Model_name()
        {
            Console.WriteLine("Del aspiron");
            Console.ReadKey();
        }
    }
    public interface class1
    {
        public void Model_name();
        public void Manufacturer();
    }

    public class Consolegame:class1
    {
        public void Model_name()
        {
            Console.WriteLine("PLAYSTATION 5");
            Console.ReadKey();
        }
        public void Manufacturer()
        {
            Console.WriteLine("SONY");
            Console.ReadKey();
        }
    }
    class Mobile
    {
        public void Model_name()
        {
            Console.WriteLine("Samsung Galaxy A13");
            Console.ReadKey();
        }
    }
}
