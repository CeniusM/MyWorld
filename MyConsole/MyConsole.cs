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
    }
}