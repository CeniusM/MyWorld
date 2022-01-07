using CS_Graphics_Engine.Frame;
using CS_World;
using CS_World.World_Dimensions;
using CS_World.World_Objects;

namespace CS_Graphics_Engine.FrameRender
{
    class FrameRender
    {
        WorldDimensions worldDimensions;
        Objects objects;
        public FrameRender(WorldDimensions worldDimensions, Objects objects) // ?
        {
            this.worldDimensions = worldDimensions;
            this.objects = objects;
        }
        public void RenderFrame()
        {
            MyFrame frame = new MyFrame(400, 400);

            CS_Graphics_Engine.API.MyAPI.PrintToForm(frame);
        }
    }
}