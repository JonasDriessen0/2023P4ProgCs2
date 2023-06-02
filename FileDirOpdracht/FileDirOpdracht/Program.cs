namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\programeren\2023P4ProgCs2");

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }


            foreach (DirectoryInfo dirs in dir.GetDirectories())
            {
                Console.WriteLine(dirs.Name);
            }
        }
    }
}