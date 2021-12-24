namespace CS_Objects.Ball.Data
{
    class BallData
    {
        // float bounciness = 0f; // 0 - 1, 1 being the most bounci
        // public float rotation = 0f;
        // public float rotation_velocity = 0f;
        public float x_pos = 0f;
        public float y_pos = 0f;
        public float x_velocity = 0f;
        public float y_velocity = 0f;
        public int radius = 0;
        public BallData(float ax_pos = 0, float ay_pos = 0, float ax_velocity = 0, float ay_velocity = 0, int aradius = 1)
        {
            x_pos = ax_pos;
            y_pos = ay_pos;
            x_velocity = ax_velocity;
            y_velocity = ay_velocity;
            radius = aradius;
        }
    }
}