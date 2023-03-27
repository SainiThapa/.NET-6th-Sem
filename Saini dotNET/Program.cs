using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saini_dotNET
{
    internal class Program
    {
        static void Compare(string a, string b)
        {
            int x=Convert.ToInt32((string)a);
            int y=Convert.ToInt32((string)b);
            if(x > y) 
                Console.WriteLine(a+" is the greatest number");
            else
                Console.WriteLine(b + " is the greatest number");
        }
        static void ForLooping()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i + 1);
        }
        static void WhileLooping()
        {
            int i = 0;
            while(i!=5)
            {
                Console.WriteLine(i+1);
                i++;
            }
        }
        
        static void SwitchCase()
        {
            string a;
            Console.WriteLine("Enter the number to denote day (1-7): ");
            a= Console.ReadLine();
            int b = Convert.ToInt32(a);
            switch(b)
                {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("TRY AGAIN");
                    break;
                }
        }
        static void BitwiseOperator()
        {
            int i, j,res1,res2,res3,res4;
            string a, b;
            Console.WriteLine("Enter the value of a and b for bitwise operation: ");
            a = Console.ReadLine();
            b = Console.ReadLine();
            i=Convert.ToInt32(a);
            j=Convert.ToInt32(b);
            res1 = i & j;
            Console.WriteLine("{0} AND {1} = {2}",i,j,res1);
            res2 = i | j;
            Console.WriteLine("{0} OR {1} = {2}", i, j, res2);
            res3 = i ^ j;
            Console.WriteLine("{0} XOR {1} = {2}", i, j, res3);
            res4 = ~i;
            Console.WriteLine("~{0} = {1}", i, res4);
        }
        static void ShiftOperation()
        {
            int i, j;
            string a, b;
            Console.WriteLine("Enter the value of a for Arithmetic left Shift operation: ");
            a = Console.ReadLine();
            i = Convert.ToInt32(a);
            Console.WriteLine("{0} >> 1 = {1}", i, i >> 1);
            Console.WriteLine("Enter the value of b for Arithmetic right Shift operation: ");
            b = Console.ReadLine();
            j = Convert.ToInt32(b);
            Console.WriteLine("{0} << 1 = {1}",j,j << 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Saini");
            /*string a, b;
            Console.WriteLine("Input the value of a and b : ");
            a = Console.ReadLine();
            b = Console.ReadLine();
            Compare(a, b);
            ForLooping();*/
            //WhileLooping();
            //SwitchCase();
            //BitwiseOperator();
            ShiftOperation();
            Console.ReadKey();
        }
    }
}
