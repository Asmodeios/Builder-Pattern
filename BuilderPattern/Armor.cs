using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Armor
    {
        public string Type { get; set; }
        private Dictionary<string, string> recipe =
            new Dictionary<string, string>();

        public Armor(string type)
        {
            Type = type;
        }

        public string this[string key]
        {
            get { return recipe[key]; }
            set { recipe[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Armor type: {0}", Type);
            Console.WriteLine(" Base: {0}", recipe["base"]);
            Console.WriteLine(" Special Ingredient: {0}", recipe["special"]);
        }
    }
}
