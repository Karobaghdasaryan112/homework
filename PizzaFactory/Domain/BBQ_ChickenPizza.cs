using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Domain
{
    internal class BBQ_ChickenPizza : IPizza
    {

        /*
        public string Name { set { 
                Name = "BBQ_ChickenPizza";
            } }
        */

        //Lambda Expression
        public string Name => "BBQ_ChickenPizza";
        private readonly decimal _price;
        public BBQ_ChickenPizza(decimal price)
        {
            _price = price;
        }

        /*
        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name} Pizza");
        }
        */

        public void Prepare() => Console.WriteLine($"Preparing {Name} Pizza");
        public void Cut() => Console.WriteLine($"Cutting {Name} Pizza");
        public void Boxing() => Console.WriteLine($"Boxing {Name} Pizza");
        public decimal GetPrice() => _price;
    }
}
