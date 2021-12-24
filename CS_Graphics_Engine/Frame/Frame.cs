using CS_Graphics_Engine.Frame.Data;

namespace CS_Graphics_Engine.Frame
{
    public class MyFrame
    {
        public FrameData frameData;
        public int height;
        public int width;
        public MyFrame(int height, int width)
        {
            frameData = new FrameData(height, width);
            this.height = height;
            this.width = width;
        }
    }
}