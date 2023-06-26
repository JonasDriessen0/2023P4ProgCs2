using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines("C:\\programeren\\2023P4ProgCs2\\ConsoleMonGame\\ConsoleMonGame\\monsterdata.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                Console.WriteLine(line);
                string[] typesplit = line.Split('|');
                string[] consoleMonData = typesplit[0].Split(",");
                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consoleMonData[0];
                Console.WriteLine(dataMon.name);
                dataMon.health = int.Parse(consoleMonData[2]);
                Console.WriteLine(dataMon.health);
                dataMon.energy = int.Parse(consoleMonData[4]);
                Console.WriteLine(dataMon.energy);
                dataMon.weakness = (Element)Enum.Parse(typeof(Element), consoleMonData[6]);
                Console.WriteLine(dataMon.weakness);
            }
        }

        internal List<ConsoleMon> LoadJson(string datafile)
        {
            string json = File.ReadAllText("monsterdata.json");

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);

            return templates;
        }

        internal Skill CopySkill(Skill copyFrom)
        {
            Skill copyResult = new Skill();

            copyResult.name = copyFrom.name;
            copyResult.energyCost = copyFrom.energyCost;
            copyResult.element = copyFrom.element;
            copyResult.damage = copyFrom.damage;

            return copyResult;
        }

        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {
            ConsoleMon copyResult = new ConsoleMon();

            copyResult.name = copyFrom.name;
            copyResult.energy = copyFrom.energy;
            copyResult.health = copyFrom.health;
            copyResult.weakness = copyFrom.weakness;
            copyResult.skills = new List<Skill>();
            foreach (Skill skill in copyFrom.skills)
            {
                Skill nskill = new Skill();
                nskill.element = skill.element;
                nskill.damage = skill.damage;
                nskill.name = skill.name;
                nskill.energyCost = skill.energyCost;
                copyResult.skills.Add(nskill);

            }
            return copyResult;
        }
    }
}
