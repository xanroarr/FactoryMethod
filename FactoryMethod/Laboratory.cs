using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Laboratory
    {
        public string Name { get; set; }
        protected Laboratory(string name)
        {
            Name = name;
        }
        public abstract Potion Cook();
    }
}
