using CS_Objects.Square.Data;
using CS_Objects.Square.Physics;

namespace CS_Objects.Square
{
    class Square
    {
        public SquareData squareData { get; private set; }
        public Color color = new Color();
        public Square(SquareData anewSquare)
        {
            squareData = anewSquare;
        }

        public void SquareTick()
        {

        }
    }
}