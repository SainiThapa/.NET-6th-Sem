using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saini_dotNET
{
    class student
    {
        string car = "Volvo";
        public int maxSpeed = 200;
        public void fullSpeed()
        {
            Console.WriteLine("Car is going full speed");
        }
    }
    //Polymorphism
    class Animal
    {
        public virtual void animalsound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("Pig makes Wee weee noise");
        }
    }
    class Dog : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("Dog makes Woof Woof noises");
            Console.ReadKey();
        }
    }
        //Abstraction
    abstract class Creature
    {
        public abstract void animalsound();
        public void sleep()
        {
            Console.WriteLine("Zzzzzzzz...");
        }
    }
    class goat:Creature
    {
        public override void animalsound()
        {
            Console.WriteLine("\nThe goat says Mehh.");
        }
    }
}
