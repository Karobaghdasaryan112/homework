using PizzaFactory.Domain;
using PizzaFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("... Welcome to PizzaFactory");

            Console.WriteLine("Please Enter the pizza would you like to create");

            Console.WriteLine(
                "BBQ_Chicken - B\n" +
                "Hawaiian - H\n" +
                "Margarita - M\n" +
                "Mediterranean - Me\n" +
                "Peperoni - P\n" +
                "Supreme - S\n" +
                "Vegetable - V\n" 
                );

            string PizzaType = Console.ReadLine();

            BaseFactoryPizza PizzaFactory1 =  MakePizza( PizzaType );
            IPizza pizza =  PizzaFactory1.GetPizza();

            Console.WriteLine("your Pizza is created");

            Console.WriteLine(
                $"Name: {pizza.Name}\t" +
                $"price: {pizza.GetPrice()}\t\t"
                );

            Console.ReadLine();
        }
        private static BaseFactoryPizza MakePizza(string PizzaType)
        {
            switch (PizzaType.ToLower())
            {
                case "b":
                    return new BBQ_ChickenPizzaFactory(100);
                case "h":
                    return new HawaiianPizzaFactory(200);
                case "m":
                    return new MargaritaPizzaFactory(250);
                case "me":
                    return new MediterraneanPizzaFactory(300);
                case "p":
                    return new PeperoniPizzaFactory(370);
                case "s":
                    return new SupremePizzaFactory(420);
                case "v":
                    return new VegetablePizzaFactory(560);
                default:
                    throw new Exception("Invalid Pizza Type");
            }
        }
    }

}
