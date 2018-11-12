using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmorBuilder builder;

            Anvil anvil = new Anvil();

            builder = new DragonArmorBuilder();
            anvil.Forge(builder);
            builder.Armor.Show();

            builder = new SteelArmorBuilder();
            anvil.Forge(builder);
            builder.Armor.Show();

            Console.ReadKey();
        }
    }
}
