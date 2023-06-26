using System;
using System.Text.Json;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines(datafile);
            foreach (string line in lines)
            {
                string[] typeSplit = line.Split('|');
                string[] consoleMonData = typeSplit[0].Split(',');

                ConsoleMon dataMon = new ConsoleMon();

                dataMon.name = consoleMonData[0];
                dataMon.health = Int32.Parse(consoleMonData[2]);
                dataMon.energy = Int32.Parse(consoleMonData[4]);

                Console.WriteLine(dataMon.name);
                Console.WriteLine(dataMon.health);
                Console.WriteLine(dataMon.energy);
            }
        }

        internal List<ConsoleMon> LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);

            foreach (ConsoleMon template in templates)
            {
                Console.WriteLine(template.name);
            }
            return templates;
        }

        internal Skill CopySkill(Skill copyFrom)
        {
            Skill copyResult = new Skill(copyFrom.damage, copyFrom.energyCost, copyFrom.name, copyFrom.element);
            return copyResult;
        }
        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {
            ConsoleMon copyResult = new ConsoleMon(copyFrom.health, copyFrom.energy, copyFrom.name, copyFrom.weakness);
            copyResult.skills = new List<Skill>();
            foreach (Skill skill in copyFrom.skills)
            {
                Skill copiedSkill = CopySkill(skill);
                copyResult.skills.Add(copiedSkill);
            }
            return copyResult;
        }
    }
}