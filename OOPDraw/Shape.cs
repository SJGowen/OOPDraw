using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public abstract class Shape
    {
        private float XOrigin { get; set; }
        private float YOrigin { get; set; }

        public Shape(float xOrigin, float yOrigin)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
        }

        public abstract void Draw();

        public void MoveTo(float x, float y)
        {
            XOrigin = x;
            YOrigin = y;
        }

        protected void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 270;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
        }
    }
}