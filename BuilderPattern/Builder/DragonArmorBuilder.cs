using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    class DragonArmorBuilder : ArmorBuilder
    {
        public DragonArmorBuilder()
        {
            armor = new Armor("Dragon");
        }
        public override void AddSpecial()
        {
            armor["special"] = "Dragon Skin";
        }

        public override void AddBase()
        {
            armor["base"] = "Leather";
        }
    }
}
