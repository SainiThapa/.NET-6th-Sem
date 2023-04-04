using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASync
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Starting program...");

            // Call a method asynchronously
            await DoSomethingAsync();

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
