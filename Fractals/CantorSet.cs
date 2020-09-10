using System.Drawing;

namespace Fractals
{
    class CantorSet
    {
        private readonly int h;
        private readonly Color[] colors;
        private readonly int dx;
        private readonly int dy;

        public CantorSet(int h, Color[] colors, int dx, int dy)
        { 
            this.h = h;
            this.colors = colors;
            this.dx = dx;
            this.dy = dy;
        }

        public void Draw(float x, float y, float width, Graphics graphics, int degree)
        {
            SolidBrush Black = new SolidBrush(colors[degree == 0 ? 0 : degree - 1]);
            Pen myPen = new Pen(colors[degree == 0 ? 0 : degree - 1], 0.1f);

            if (degree > 0)
            {
                graphics.DrawRectangle(myPen, x + dx, y + dy, width, 12);
                graphics.FillRectangle(Black, x + dx, y + dy, width, 12);

                y += h;

                Draw(x + width * 2 / 3, y, width / 3, graphics, degree - 1);
                Draw(x, y, width / 3, graphics, degree - 1);
            }
        }
    }
}
