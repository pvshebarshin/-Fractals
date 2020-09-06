using System.Drawing;

namespace Fractals
{
    class Hilbert
    {
        private float LastX;
        private float LastY;
        private Color[] colors;

        public Hilbert(float LastX, float LastY, Color[] colors)
        { 
            this.LastX = LastX;
            this.LastY = LastY;
            this.colors = colors;
        }

        public void Draw(int x, int y, Graphics graphics, int degree, float start_length)
        { 
            DrawR(degree, start_length, 0, graphics);
        }

        private void DrawR(int degree, float dx, float dy, Graphics graphics)
        {
            if (degree > 1)
                DrawR(degree - 1, dy, dx, graphics);
            Drawing(graphics, dx, dy, degree);

            if (degree > 1)
                DrawR(degree - 1, dx, dy, graphics);
            Drawing(graphics, dy, dx, degree);

            if (degree > 1)
                DrawR(degree - 1, dx, dy, graphics);
            Drawing(graphics, -dx, -dy, degree);

            if (degree > 1)
                DrawR(degree - 1, -dy, -dx, graphics);
        }

        private void Drawing(Graphics graphics, float dx, float dy, int degree)
        {
            graphics.DrawLine(new Pen(colors[colors.Length - degree], 1), LastX, LastY, 
                LastX + dx, LastY + dy);
            this.LastX += dx;
            this.LastY += dy;
        }
    }
}
