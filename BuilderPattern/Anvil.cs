using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Anvil
    {
        public void Forge(ArmorBuilder builder)
        {
            builder.AddSpecial();
            builder.AddBase();
        }

    }
}
