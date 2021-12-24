using CS_Graphics_Engine.Frame;

namespace CS_Graphics_Engine.API
{
    public class MyAPI
    {
        public static void PrintToForm(MyFrame frame)
        {
            Bitmap bitmap = new Bitmap(400, 400);
            for (int i = 0; i < 400; i++)
            {
                for (int j = 0; j < 400; j++)
                {
                    bitmap.SetPixel(i, j, frame.frameData.pixels[i, j]);
                }
            }
        }
    }
}