using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saini_dotNET
{
    internal class Program
    {
        private string model = "MUSTANG";
        static void Compare(string a, string b)
        {
            int x = Convert.ToInt32((string)a);
            int y = Convert.ToInt32((string)b);
            if (x > y)
                Console.WriteLine(a + " is the greatest number");
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
            while (i != 5)
            {
                Console.WriteLine(i + 1);
                i++;
            }
        }

        static void SwitchCase()
        {
            string a;
            Console.WriteLine("Enter the number to denote day (1-7): ");
            a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            switch (b)
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
            int i, j, res1, res2, res3, res4;
            string a, b;
            Console.WriteLine("Enter the value of a and b for bitwise operation: ");
            a = Console.ReadLine();
            b = Console.ReadLine();
            i = Convert.ToInt32(a);
            j = Convert.ToInt32(b);
            res1 = i & j;
            Console.WriteLine("{0} AND {1} = {2}", i, j, res1);
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
            Console.WriteLine("{0} << 1 = {1}", i, i << 1);
            Console.WriteLine("Enter the value of b for Arithmetic right Shift operation: ");
            b = Console.ReadLine();
            j = Convert.ToInt32(b);
            Console.WriteLine("{0} >> 1 = {1}", j, j >> 1);
        }
        static void Cont_Break()
        {
            Console.WriteLine("Example of Continue: ");
            for (int i = 0; i < 10; i++)
            { if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("Example of Break: ");
            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("Example of GOTO: ");
            int j = 0;
        start:
            if (j < 5)
            {
                Console.WriteLine("j = " + j);
                j++;
            goto start;
            }
        }
        static void BooleanDataType()
        {
            bool YES = true;
            Console.WriteLine("Enter true or false: ");
            string answer = Console.ReadLine();
            bool ans2 = Convert.ToBoolean(answer);
            if (ans2 == YES)
                Console.WriteLine("True value");
            else
                Console.WriteLine("False Value");
        }
        static void For_Each_Method()
        {
            var numbers = new List<int>() { 23, 24, 45, 76, 87 };
            int sum = 0;
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                sum += num;
            }
            Console.WriteLine("Sum is " + sum + "\n");

            string[] cars = { "BMW", "Ford", "Lamborghini", "Tesla" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
        enum Days
        {
            Monday, Tuesday, Wednesday, Friday, Saturday, Sunday
        }
        static void Enumeration()
        {

            Console.WriteLine((int)Days.Monday);
            Console.WriteLine((int)Days.Wednesday);
            Console.WriteLine((int)Days.Saturday);
        }
        struct Drama 
        {
            public int year;
            public string name;
        }
        static void structure()
        {
            Drama d=new Drama();
            d.year = 2016;
            d.name = "Goblin";
            Console.WriteLine("Year = "+d.year+" Name = "+d.name);
        }

        static void TernaryOp()
        {
            int a, b;
            string c, d;
            c = Console.ReadLine();
            d = Console.ReadLine();
            a = Convert.ToInt32(c);
            b = Convert.ToInt32(d);
            var result = a > b ? a : b;
            Console.WriteLine(result + " is the greatest number");
        }

    static void Main(string[] args)
        {
            Console.WriteLine("Hello Saini");
            string a, b;
            Console.WriteLine("Input the value of a and b : ");
            a = Console.ReadLine();
            b = Console.ReadLine();
            Compare(a, b);
            ForLooping();
            WhileLooping();
            SwitchCase();
            BitwiseOperator();
            ShiftOperation();
            Cont_Break();
            BooleanDataType();
            For_Each_Method();
            structure();
            Enumeration();
            TernaryOp();
            Console.ReadKey();
        }
    }
}

            /*student st1 = new student();
            Console.WriteLine(st1.maxSpeed);
            */
            /*Player p1= new Player();
            Console.WriteLine("Player name = "+p1.name);
            Console.WriteLine("Player ID = "+p1.id);
            p1.SetId(32);
            Console.WriteLine("Player ID= " + p1.id);
*/
            /*p1.name = "Sushil";       
            Console.WriteLine(p1.name);*/
            //Program new1= new Program();
            //Console.WriteLine(new1.model+" is the PRIVATE member of the class Program");

            //Console.WriteLine(p1.roll); will send an error cause roll is a private member of the Player class

            //GET SET
            /*            p1.Name = "Prabesh";
                        Console.WriteLine("Name = "+p1.Name);

                        // Inheritance
                        Car c1= new Car();
                        Console.WriteLine("Version = " + c1.version);
                        Console.WriteLine("Model name = "+c1.modelName);*/

            //Polymorphism
            //Animal myanimal1= new Animal();
            //Animal myanimal2 = new Pig();
            //Animal myanimal3 = new Dog();
            //myanimal1.animalsound();
            //myanimal2.animalsound();
            //myanimal3.animalsound();

            //Abstraction
            //            Creature obj1= new Creature(); /Cannot create an instance of the aabstract class or interface 'Creature'
            //goat mygoat = new goat();
            //mygoat.animalsound();
            //mygoat.sleep();

            //Try and catch
            /*try
            {
                string[] Names = new string[5];
                Names[0] = "Saini";
                Names[1] = "Sushil";
                Names[2] = "Suman";
                Names[3] = "Ramesh";
                Names[4] = "Raaj";
                //Names[5] = "Santosh";
                foreach (string name in Names)
                {
                    Console.WriteLine(name);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong");
            }*/
