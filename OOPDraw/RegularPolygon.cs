using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public class RegularPolygon : Shape
    {
        private float SideLength { get; set; }
        private int Sides { get; set; }

        public RegularPolygon(float xOrigin, float yOrigin, float sideLength, int sides) : base(xOrigin, yOrigin)
        {
            SideLength = sideLength;
            Sides = sides;
        }

        public override void Draw()
        {
            ResetTurtle();
            for (int i = 0; i < Sides; i++)
            {
                Turtle.Rotate((float)360 / Sides);
                Turtle.Forward(SideLength);
            }
        }
    }
}
