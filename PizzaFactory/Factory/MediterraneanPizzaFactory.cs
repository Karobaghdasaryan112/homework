using PizzaFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Factory
{
    internal class MediterraneanPizzaFactory : BaseFactoryPizza
    {
        private readonly decimal _price;
        public MediterraneanPizzaFactory(decimal Price)
        {
            _price = Price;
        }
        public override IPizza GetPizza()
        {
            return new MediterraneanPizza(_price);
        }
    }
}
