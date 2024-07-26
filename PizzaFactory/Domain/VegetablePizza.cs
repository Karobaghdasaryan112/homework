using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Domain
{
    internal class VegetablePizza : IPizza
    {
        public string Name => "VegetablePizza";
        private readonly decimal _price;
        public VegetablePizza(decimal price)
        {
            _price = price;
        }
        public void Prepare() => Console.WriteLine($"Preparing {Name} Pizza");
        public void Cut() => Console.WriteLine($"Cutting {Name} Pizza");
        public void Boxing() => Console.WriteLine($"Boxing {Name} Pizza");
        public decimal GetPrice() => _price;

    }
}
