namespace CS_MyConsole
{
    class MyConsole
    {
        const string path = @"C:\GitHub\CS_MyWorld\MyConsole\Console.txt";
        public static void WriteLine(string text)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            lines.Add(text);
            File.WriteAllLines(path, lines);
        }
        public static void Write(string text)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            lines[lines.Count()-1] = lines[lines.Count()-1] + text;
            File.WriteAllLines(path, lines);
        }
    }
}