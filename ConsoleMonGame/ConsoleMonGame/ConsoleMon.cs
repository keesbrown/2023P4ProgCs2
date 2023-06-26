using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleMonGame
{


    internal class ConsoleMon
    {
        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }

        public List<Skill> skills { get; set; }
        public Element weakness { get; set; }
        internal void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }

        public ConsoleMon()
        {
        }

        internal ConsoleMon(int health, int energy, string name, Element weakness)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;
            this.weakness = weakness;
        }
    }

}