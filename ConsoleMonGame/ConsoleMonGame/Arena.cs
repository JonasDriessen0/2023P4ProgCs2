using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class Arena
    {
        internal void Fight(ConsoleMon fighterA, ConsoleMon fighterB)
        {
            Console.WriteLine($"Fight between {fighterA.name} and {fighterB.name} begins!");

            Skill skillA = fighterA.skills[0];
            skillA.UseOn(fighterB, fighterA);
            Console.WriteLine($"{fighterA.name} uses {skillA.name} on {fighterB.name}. {fighterB.name} takes {skillA.damage} damage!");

            Skill skillB = fighterB.skills[0];
            skillB.UseOn(fighterA, fighterB);
            Console.WriteLine($"{fighterB.name} uses {skillB.name} on {fighterA.name}. {fighterA.name} takes {skillB.damage} damage!");

            Console.WriteLine("Fight ends!");
        }
    }
}