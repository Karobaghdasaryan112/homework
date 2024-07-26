using PizzaFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Factory
{
    internal class SupremePizzaFactory : BaseFactoryPizza
    {
        private readonly decimal _price;
        public SupremePizzaFactory(decimal Price)
        {
            _price = Price;
        }
        public override IPizza GetPizza()
        {
            return new SupremePizza(_price);
        }
    }
}
