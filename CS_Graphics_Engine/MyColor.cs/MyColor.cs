namespace CS_Color
{
    public struct MyColor
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
        public MyColor(byte A = 0, byte R = 0, byte G = 0, byte B = 0)
        {
            this.A = A;
            this.R = R;
            this.G = G;
            this.B = B;
        }
    }
}