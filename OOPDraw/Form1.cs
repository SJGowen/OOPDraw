using Nakov.TurtleGraphics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        private List<Shape> Shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs me)
        {
            var xOrigin = me.X - Width / 2 + 8;
            var yOrigin = Height / 2 - me.Y - 19;
            var selectedItem = (string)comboBox1.SelectedItem;
            switch (selectedItem)
            {
                case "Draw Triangle":
                    var triangle = new EquilateralTriangle(xOrigin, yOrigin, 100);
                    Shapes.Add(triangle);
                    break;
                case "Draw Square":
                    var square = new Square(xOrigin, yOrigin, 100);
                    Shapes.Add(square);
                    break;
                case "Draw Rectangle":
                    var rectangle = new Rectangle(xOrigin, yOrigin, 100, 50);
                    Shapes.Add(rectangle);
                    break;
                case "Draw Pentagon":
                    var pentagon = new Pentagon(xOrigin, yOrigin, 90);
                    Shapes.Add(pentagon);
                    break;
                case "Draw Hexagon":
                    var hexagon = new Hexagon(xOrigin, yOrigin, 80);
                    Shapes.Add(hexagon);
                    break;
                case "Draw Heptagon":
                    var heptagon = new Heptagon(xOrigin, yOrigin, 70);
                    Shapes.Add(heptagon);
                    break;
                case "Draw Octagon":
                    var octagon = new Octagon(xOrigin, yOrigin, 60);
                    Shapes.Add(octagon);
                    break;
                case "Move Shape":
                    if (Shapes.Count > 0) Shapes[Shapes.Count - 1].MoveTo(xOrigin, yOrigin);
                    break;
                default:
                    MessageBox.Show("Please select a 'Shape to Draw'", "Error", MessageBoxButtons.OK);
                    comboBox1.Focus();
                    break;
            }
            DrawAll();
        }

        public void DrawAll()
        {
            Turtle.Dispose();
            foreach (var shape in Shapes)
            {
                shape.Draw();
            }
        }
    }
}
