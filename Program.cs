using CS_MyGame;

namespace MyForm;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());

        Game game = new Game();
        game.Start();
    }
}