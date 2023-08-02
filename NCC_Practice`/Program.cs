using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCC_Practice_
{
    internal class Program:Class1
    {
        public static async Task function1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i} number from function1");
                }
            });
        }
        public static async Task function2()
        {
            for(int  i = 0; i < 5;i++)
            {
                Console.WriteLine("Counter from function2");
            }
        }
        static async Task Main()
        {
            Console.WriteLine("Starting Program...");
            //calls a method asynchronously
            await function1();
            function2();

            await DoSomethingAsync();
            Console.WriteLine("Program Finished");
            Console.ReadKey();
        }

        static async Task DoSomethingAsync()
        {
            Console.WriteLine("Starting Async method....");
            //Simulate some work that takes 1 second
            await Task.Delay(1000);
            Console.WriteLine("Executing...");
            await Task.Delay(1000);
            Console.WriteLine("3.......");
            await Task.Delay(1000);
            Console.WriteLine("2.......");
            await Task.Delay(1000);
            Console.WriteLine("1.......");
            await Task.Delay(1000);
            Console.WriteLine("done..!!");
            await Task.Delay(1000);
            Console.WriteLine("Async method finished");
        }

        /*static void Compare()
        {
            int a, b;
            Console.WriteLine("Enter the value of a and b : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if(a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else if(a > b){
                Console.WriteLine("a is greater than b");
            }
            else
            {
                Console.WriteLine("b is greater than a");
            }
        }
        static void ForLoop()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
        
        static void WhileLoop()
        {
            int i=1;
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void SwitchCase() 
        {
            Console.WriteLine("Choose a number from 1-7");
            int a= Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                case 6: Console.WriteLine("Friday"); break;
                case 7: Console.WriteLine("Saturday"); break;

                default: Console.WriteLine("Invalid Option"); break;
            }
        }

        class Indexer
        {
            private string[] names = new string[3];
            public string this[int i]
            {
                get { return names[i]; }
                set { names[i] = value; }
            }
        }

        static void TryCatch()
        {
            try
            {
            string[] name = new string[5];
            name[0] = "Saini";
            name[1] = "Sammy";
            name[2] = "Sam";
            name[3] = "Sandy";
            name[4] = "Raaaj";
                foreach(string n in name)
                {
                    Console.WriteLine(n);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        static void List_1()
        {
            List<int> list = new List<int>();
            list.Add(36);
            list.Add(44);
            list.Add(51);
            list.Add(66);
            list.Add(70);
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //Compare a and b
            //Compare();

            //For looping
            //ForLoop();

            //While Looping
            // WhileLoop();

            //SwitchCase
            //
            // SwitchCase();

            *//*//Try Catch*//*
            //TryCatch();

            *//* Inheritance */
            /*Program c = new Program();
            c.Function1();*/

            /*   INDEXER  */
            /*  Indexer i = new Indexer();
          i[0] = "ABC";
          i[1] = "MNO";
          i[2] = "XYZ";

          for(int j = 0; j < 3; j++)
          {
              Console.WriteLine(i[j]);
          }*/


            /*              <LIST>              *//*
            //List_1();


            *//*           File Writing               */
           /* Program program = new Program();
            program.FileWriting();*//*

            Console.ReadKey();

        }*/
    }
}
