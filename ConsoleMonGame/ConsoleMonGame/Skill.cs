using System;

namespace ConsoleMonGame

{
    internal class Skill
    {
        public int damage { get; set; }
        public int energyCost { get; set; }
        public string name { get; set; }
        internal Element element;
        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(this.energyCost);
            target.TakeDamage(this.damage);
            if (target.weakness == this.element)
            {
                target.TakeDamage(this.damage / 2);
            }
        }

        public Skill()
        {
        }

        internal Skill(int damage, int energyCost, string name, Element element)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
            this.element = element;
        }
    }
}