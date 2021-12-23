using CS_Objects.Ball.Data;
using CS_Objects.Ball.Physics;

namespace CS_Objects.Ball
{
    class Ball
    {
        public BallData ballData { get; private set; }
        public Color color = new Color();
        public Ball(BallData anewBall)
        {
            ballData = anewBall;
        }

        public void BallTick()
        {

        }
    }
}