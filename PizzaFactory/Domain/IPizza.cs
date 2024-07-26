using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Domain
{
    internal interface IPizza
    {
        string Name { get; }
        decimal GetPrice();
        void Prepare();
        void Cut();
        void Boxing();
    }
}
