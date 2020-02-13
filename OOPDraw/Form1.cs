using Nakov.TurtleGraphics;
using System;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var turtleX = e.X - Width / 2 + 8;
            var turtleY = Height / 2 - e.Y - 19;
            var selectedItem = (string)comboBox1.SelectedItem;
            switch (selectedItem)
            {
                case "Draw Triangle": 
                    DrawTriangle(turtleX, turtleY, 100);
                    break;
                case "Draw Square":
                    DrawSquare(turtleX, turtleY, 100);
                    break;
                case "Draw Rectangle":
                    DrawRectangle(turtleX, turtleY, 50, 100);
                    break;
                case "Draw Pentagon":
                    DrawPentagon(turtleX, turtleY, 90);
                    break;
                case "Draw Hexagon":
                    DrawHexagon(turtleX, turtleY, 80);
                    break;
                case "Draw Heptagon":
                    DrawHeptagon(turtleX, turtleY, 70);
                    break;
                case "Draw Octagon":
                    DrawOctagon(turtleX, turtleY, 60);
                    break;
                default:
                    MessageBox.Show("Please select an item in the Combo Box", "Error", MessageBoxButtons.OK);
                    comboBox1.Focus();
                    break;
            }
        }

        private static void PrepareForDrawing(float xOrigin, float yOrigin)
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 270;
            Turtle.X = xOrigin;
            Turtle.Y = yOrigin;
        }

        private static void DrawRegularShape(int sides, float sideLength)
        {
            for (int i = 0; i < sides; i++)
            {
                Turtle.Rotate((float)360 / sides);
                Turtle.Forward(sideLength);
            }
        }

        private static void DrawTriangle(float xOrigin, float yOrigin, float sideLength)
        {
            PrepareForDrawing(xOrigin, yOrigin);
            DrawRegularShape(3, sideLength);
        }

        private void DrawSquare(float xOrigin, float yOrigin, float sideLength)
        {
            PrepareForDrawing(xOrigin, yOrigin);
            DrawRegularShape(4, sideLength);
        }

        private void DrawRectangle(float xOrigin, float yOrigin, float height, float width)
        {
            PrepareForDrawing(xOrigin, yOrigin);
            Turtle.Rotate(90);
            Turtle.Forward(height);
            Turtle.Rotate(90);
            Turtle.Forward(width);
            Turtle.Rotate(90);
            Turtle.Forward(height);
            Turtle.Rotate(90);
            Turtle.Forward(width);
        }

        private void DrawPentagon(float xOrigin, float yOrigin, float sideLength)
        {
            PrepareForDrawing(xOrigin, yOrigin);
            DrawRegularShape(5, sideLength);
        }

        private void DrawHexagon(float xOrigin, float yOrigin, float sideLength)
        {
            PrepareForDrawing(xOrigin, yOrigin);
            DrawRegularShape(6, sideLength);
        }

        private void DrawHeptagon(float xOrigin, float yOrigin, float sideLength)
        {
            PrepareForDrawing(xOrigin, yOrigin);
            DrawRegularShape(7, sideLength);
        }

        private void DrawOctagon(float xOrigin, float yOrigin, float sideLength)
        {
            PrepareForDrawing(xOrigin, yOrigin);
            DrawRegularShape(8, sideLength);
        }
    }
}
