using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        delegate int Sum(int x, int y);
        delegate int Product(int x, int y);
        static int calculate1(int x, int y)
        {
            return x+y;
        }
        static int calculate2(int x, int y)
        {
            return x * y;
        }
        delegate void myDelegate(Program1 pro);

        static void myFunction(Program1 obj1)
        {
            obj1.mymethod(1,2);
        }
        static void Main(string[] args)
        { 
                string pathName = @"saini.txt";
                string writeText = "My name is Saini Thapa";
                File.WriteAllText("saini.txt", writeText);
                string readText = File.ReadAllText("saini.txt");
                Console.WriteLine(readText);
                Console.ReadKey();
            }
        }
    

    /*            //DELEGATE INT
                Sum p1 = calculate1;
                Product d1 = calculate2;
                Console.WriteLine("Enter two numbers to perform addition and multiplication: ");
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                int c = Convert.ToInt32(a);
                int d = Convert.ToInt32(b);
                int result1 = p1(c, d);
                int result2 = d1(c, d);
                Console.WriteLine("Sum = " + result1);
                Console.WriteLine("Product = " + result2);/*/

    /*//DELEGATE CLASSOBJ
    Program1 obj1 = new Program1();
            myDelegate D = myFunction;
            D(obj1);
        }
    }
*/
}