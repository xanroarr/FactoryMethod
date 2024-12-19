using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class HealPotionLaboratory : Laboratory
    {
        public HealPotionLaboratory(string name) : base(name)
        {
        }

        public override Potion Cook()
        {
            return new HealPotion();
        }
    }
}
