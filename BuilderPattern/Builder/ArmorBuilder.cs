using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
   abstract class ArmorBuilder
    {
        protected Armor armor;

        public Armor Armor
        {
            get { return armor; }
        }

        public abstract void AddSpecial();
        public abstract void AddBase();
    }
}
