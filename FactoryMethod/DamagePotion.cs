using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DamagePotion : Potion
    {
        public DamagePotion()
        {
            Console.WriteLine("Morphine cooked");
        }
    }
}
