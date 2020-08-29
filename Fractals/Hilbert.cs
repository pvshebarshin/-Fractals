using System.Drawing;

namespace Fractals
{
    class Hilbert
    {
        private float LastX;
        private float LastY;

        public Hilbert(float LastX, float LastY)
        { 
            this.LastX = LastX;
            this.LastY = LastY;
        }

        public void Draw(int x, int y, Graphics graphics, int degree, float start_length)
        { 
            DrawR(degree, start_length, 0, graphics);
        }

        private void DrawR(int degree, float dx, float dy, Graphics graphics)
        {
            if (degree > 1)
                DrawR(degree - 1, dy, dx, graphics);
            Drawing(graphics, dx, dy);

            if (degree > 1)
                DrawR(degree - 1, dx, dy, graphics);
            Drawing(graphics, dy, dx);

            if (degree > 1)
                DrawR(degree - 1, dx, dy, graphics);
            Drawing(graphics, -dx, -dy);

            if (degree > 1)
                DrawR(degree - 1, -dy, -dx, graphics);
        }

        private void Drawing(Graphics graphics, float dx, float dy)
        {
            graphics.DrawLine(Pens.Black, LastX, LastY, LastX + dx, LastY + dy);
            this.LastX += dx;
            this.LastY += dy;
        }
    }
}
