using PizzaFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Factory
{
    internal class MargaritaPizzaFactory : BaseFactoryPizza
    {
        private readonly decimal _price;
        public MargaritaPizzaFactory(decimal Price)
        {
            _price = Price;
        }
        public override IPizza GetPizza()
        {
            return new MargaritaPizza(_price);
        }
    }
}

