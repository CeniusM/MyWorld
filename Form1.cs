namespace MyForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public static void LoadBitMap2(Bitmap frame)
    {
        System.Drawing.Graphics graphicsObj;

        if (CS_Game.Game.myForm != null)
        {
            graphicsObj = CS_Game.Game.myForm.CreateGraphics();
            //.CreateGraphics();

            graphicsObj.DrawImage(frame, 0, 0);
        }
    }
}