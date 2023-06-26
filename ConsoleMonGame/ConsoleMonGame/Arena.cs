using System;
namespace ConsoleMonGame
{
    internal class Arena
    {
        internal void Fight(ConsoleMon fighterA, ConsoleMon fighterB)
        {
            while (true)
            {

                Console.WriteLine("fighterA has " + fighterA.health + " health");
                fighterA.TakeDamage(fighterB.skills[0].damage);
                Console.WriteLine("fighterB Did " + fighterB.skills[0].damage + " damage");
                Console.WriteLine("fighterA health is now " + fighterA.health);
                Console.WriteLine("");
                if (fighterA.health <= 0)
                {
                    Console.WriteLine("fighterB Won");
                    return;
                }

                Console.WriteLine("fighterB has " + fighterB.health + " health");
                fighterB.TakeDamage(fighterA.skills[0].damage);
                Console.WriteLine("fighterA Did " + fighterA.skills[0].damage + " damage");
                Console.WriteLine("fighterB health is now " + fighterB.health);
                Console.WriteLine("");
                Console.WriteLine("");
                if (fighterB.health <= 0)
                {
                    Console.WriteLine("fighterA Won");
                    return;
                }
            }
        }
    }
}