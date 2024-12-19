using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class HealPotion: Potion
    {
        public HealPotion() 
        {
            Console.WriteLine("Decoction of chamomile cooked");
        }
    }
}
