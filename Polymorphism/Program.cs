using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }



    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Barks");
        }

    }
    class Program
    {

        static void Main()
        {
            Animal myAnimal = new Dog();  // Parent class reference holding a child object
            myAnimal.MakeSound();
        }
    }
}