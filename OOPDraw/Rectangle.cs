﻿using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public class Rectangle : Shape
    {
        private float Width { get; set; }
        private float Height { get; set; }
        
        public Rectangle(float xOrigin, float yOrigin, float width, float height) : base(xOrigin, yOrigin)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            ResetTurtle();
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
