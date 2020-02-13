using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public class Rectangle : RegularShape
    {
        private float Width { get; set; }
        private float Height { get; set; }
        
        public Rectangle(float xOrigin, float yOrigin, float width, float height) : base(xOrigin, yOrigin, (width + height) / 2, 4)
        {
            Width = width;
            Height = height;
        }

        public new void Draw()
        {
            base.PrepareForDrawing();
            for (int i = 0; i < 2; i++)
            {
                Turtle.Rotate(90);
                Turtle.Forward(Height);
                Turtle.Rotate(90);
                Turtle.Forward(Width);
            }
        }
    }
}
