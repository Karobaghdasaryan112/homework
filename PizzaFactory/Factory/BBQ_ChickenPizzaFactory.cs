using PizzaFactory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Factory
{
    internal class BBQ_ChickenPizzaFactory : BaseFactoryPizza
    {
        private readonly decimal _price;
        public BBQ_ChickenPizzaFactory(decimal Price)
        {
            _price = Price;
        }
        public override IPizza GetPizza()
        {
            return new BBQ_ChickenPizza(_price);
        }


    }   
}
