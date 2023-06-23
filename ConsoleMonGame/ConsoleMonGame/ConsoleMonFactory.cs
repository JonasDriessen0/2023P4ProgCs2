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

        internal void LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);
            Console.WriteLine(json);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
        }
    }
}
