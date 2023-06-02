using System.IO;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("leesdezefile.txt");

            foreach (string line in content)
                Console.WriteLine(line);

            string[] content2 = new string[] { "bruh" };
            File.WriteAllText("C:\\programeren\\2023P4ProgCs2\\FileIOOpdracht\\FileIOOpdracht\\bin\\Debug\\net7.0\\leesdezefile.txt", "Ik haat dit");

            string[] lines = { "", "New line 1", "New line 2" };
            File.AppendAllLines("C:\\programeren\\2023P4ProgCs2\\FileIOOpdracht\\FileIOOpdracht\\mijnnieuwefile.txt", lines);

            Directory.CreateDirectory("output");
        }
    }
}