using CS_Objects.Ball.Data;

namespace CS_Objects.Ball
{
    class Ball
    {
        public BallData ballData { get; private set; }
        public Ball(BallData anewBall)
        {
            ballData = anewBall;
        }

        public void BallTick()
        {

        }
    }
}