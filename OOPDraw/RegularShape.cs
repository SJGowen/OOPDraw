using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public class RegularShape
    {
        private float XOrigin { get; set; }
        private float YOrigin { get; set; }
        private float SideLength { get; set; }
        private int Sides { get; set; }

        public RegularShape(float xOrigin, float yOrigin, float sideLength, int sides)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            SideLength = sideLength;
            Sides = sides;
        }

        public void PrepareForDrawing()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 270;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
        }

        public void Draw()
        {
            PrepareForDrawing();
            for (int i = 0; i < Sides; i++)
            {
                Turtle.Rotate((float)360 / Sides);
                Turtle.Forward(SideLength);
            }
        }
    }
}
