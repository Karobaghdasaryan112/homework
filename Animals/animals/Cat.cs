using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.animals
{
    internal class Cat : animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat say ..Meow ..Meow");
        }
    }
}
