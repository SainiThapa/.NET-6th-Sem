using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCC_Practice_
{
    public class Class1
    {
        public void Function1()
        {
            Console.WriteLine("Inheritance example");
        }

        public void FileWriting() 
        {
            string pathname = @"thapa.txt";
            string writeText = "I am a student in BMC";
            File.WriteAllText("abc.txt", writeText);
            string readtext = File.ReadAllText("abc.txt");
            Console.WriteLine(readtext);
        }
    }
}
