using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            }
        }
    }
}
