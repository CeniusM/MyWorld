using CS_Color;

namespace CS_Graphics_Engine.Frame.Data
{
    public class FrameData
    {
        public Color[,] pixels;
        public FrameData(int height, int width)
        {
            pixels = new Color[height, width];
        }
    }
}