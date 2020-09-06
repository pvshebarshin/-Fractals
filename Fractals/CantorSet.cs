using System.Drawing;

namespace Fractals
{
    class CantorSet
    {
        private int h;
        private Color[] colors;

        public CantorSet(int h, Color[] colors)
        { 
            this.h = h;
            this.colors = colors;
        }

        public void Draw(float x, float y, float width, Graphics graphics, int degree)
        {
            SolidBrush Black = new SolidBrush(colors[degree == 0 ? 0 : degree - 1]);
            Pen myPen = new Pen(colors[degree == 0 ? 0 : degree - 1], 0.1f);

            if (degree > 0)
            {
                graphics.DrawRectangle(myPen, x, y, width, 12);
                graphics.FillRectangle(Black, x, y, width, 12);

                y += this.h;

                Draw(x + width * 2 / 3, y, width / 3, graphics, degree - 1);
                Draw(x, y, width / 3, graphics, degree - 1);
            }
        }
    }
}
