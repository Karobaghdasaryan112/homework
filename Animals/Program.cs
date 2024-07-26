using Animals.animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog sound
            Dog dog = new Dog();
            dog.MakeSound();

            Console.WriteLine("------------------------");

            //Cat sound
            Cat cat = new Cat();
            cat.MakeSound();

            Console.ReadLine();
        }
    }
}
