using Nakov.TurtleGraphics;
using System.Collections.Generic;
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
            var xOrigin = e.X - Width / 2 + 8;
            var yOrigin = Height / 2 - e.Y - 19;
            var selectedItem = (string)comboBox1.SelectedItem;
            switch (selectedItem)
            {
                case "Draw Triangle":
                    var triangle = new EquilateralTriangle(xOrigin, yOrigin, 100);
                    triangle.Draw();
                    break;
                case "Draw Square":
                    var square = new Square(xOrigin, yOrigin, 100);
                    square.Draw();
                    break;
                case "Draw Rectangle":
                    var rectangle = new Rectangle(xOrigin, yOrigin, 100, 50);
                    rectangle.Draw();
                    break;
                case "Draw Pentagon":
                    var pentagon = new Pentagon(xOrigin, yOrigin, 90);
                    pentagon.Draw();
                    break;
                case "Draw Hexagon":
                    var hexagon = new Hexagon(xOrigin, yOrigin, 80);
                    hexagon.Draw();
                    break;
                case "Draw Heptagon":
                    var heptagon = new Heptagon(xOrigin, yOrigin, 70);
                    heptagon.Draw();
                    break;
                case "Draw Octagon":
                    var octagon = new Octagon(xOrigin, yOrigin, 60);
                    octagon.Draw();
                    break;
                default:
                    MessageBox.Show("Please select a 'Shape to Draw'", "Error", MessageBoxButtons.OK);
                    comboBox1.Focus();
                    break;
            }
        }
    }
}
