using MyForm;
using CS_World;

namespace CS_Game
{
    class Game
    {
        public static Form1? myForm;
        public World myWorld = new World();
        public Game(Form1 AmyForm)
        {
            myForm = AmyForm;
        }
        public void Start()
        {
            myWorld.Start();
            
        }
    }
}