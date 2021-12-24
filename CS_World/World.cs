using CS_World.World_Objects;
using CS_Objects.Ball;
using CS_Objects.Ball.Data;
using CS_World.World_Dimensions;


// using CS_o Ball;
// using CS_Ball.Data;
// using CS_World.World_Dimensions;
// using CS_World.World_Objects;
using CS_Graphics_Engine.FrameRender;

namespace CS_World
{
    public class World
    {
        private WorldDimensions worldDimensions = new WorldDimensions();
        private Objects objects = new Objects();
        private FrameRender myRender;
        public World()
        {
            myRender = new FrameRender(worldDimensions, objects);
        }

        public void Start()
        {
            myRender.RenderFrame();
        }

        private void WorldTick()
        {

        }
    }
}