namespace CS_Objects.Square.Data
{
    class SquareData
    {
        // public float rotation = 0f;
        // public float rotation_velocity = 0f;
        public float x_pos = 0f;
        public float y_pos = 0f;
        public float x_velocity = 0f;
        public float y_velocity = 0f;
        public float height = 0.5f;
        public float width = 0.5f;
        public SquareData(float ax_pos = 0, float ay_pos = 0, float ax_velocity = 0, float ay_velocity = 0, float aheight = 0, float awidth = 0)
        {
            x_pos = ax_pos;
            y_pos = ay_pos;
            x_velocity = ax_velocity;
            y_velocity = ay_velocity;
            height = aheight;
            width = awidth;
        }
    }
}