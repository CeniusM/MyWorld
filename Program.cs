using CS_Game;
using CS_Testing;

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

        Form1 myForm = new Form1();

        Application.Run(myForm);

        Game game = new Game(myForm);
        game.Start();
    }
}