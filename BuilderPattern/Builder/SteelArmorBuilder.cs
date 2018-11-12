using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    class SteelArmorBuilder : ArmorBuilder
    {
        public SteelArmorBuilder()
        {
            armor = new Armor("Steel Armor");
        }

        public override void AddSpecial()
        {
            armor["special"] = "none";
        }

        public override void AddBase()
        {
            armor["base"] = "Steel";
        }
    }
}
