using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASync
{
    internal class Program
    {
       public static async Task Function1()
        {
            await Task.Run(() =>
                {
                for(int i= 0; i < 5; i++)
                {
                    Console.WriteLine($"{i} number from function1");
                }
            });
        }
        public static async Task function2()
        {
            for(int i= 0;i<5; i++)
            Console.WriteLine("Counter from function 2"); 
        }
        static async Task Main()
        {
            Console.WriteLine("Starting program...");

            // Call a method asynchronously
            await Function1();
            function2();
            //await DoSomethingAsync();

            Console.WriteLine("Program finished.");
            Console.ReadKey();
        }

        static async Task DoSomethingAsync()
        {
            Console.WriteLine("Starting async method...");

            // Simulate some work that takes 1 second
            await Task.Delay(1000);
            Console.WriteLine("Executing.....");
            await Task.Delay(1000);
            Console.Write("3.....");
            await Task.Delay(800);
            Console.Write("2.....");
            await Task.Delay(800);
            Console.Write("1.....");
            await Task.Delay(1000);
            Console.WriteLine("done!");
            await Task.Delay(1000);
            Console.WriteLine("Async method finished.");
        }
    }
}
