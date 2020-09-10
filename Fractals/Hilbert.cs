using System.Drawing;

namespace Fractals
{
    class Hilbert
    {
        private float LastX;
        private float LastY;
        private Color[] colors;
        private readonly int dx;
        private readonly int dy;

        public Hilbert(float LastX, float LastY, Color[] colors, int dx, int dy)
        { 
            this.LastX = LastX;
            this.LastY = LastY;
            this.colors = colors;
            this.dx = dx;
            this.dy = dy;
        }

        public void Draw(Graphics graphics, int degree, float start_length)
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
            graphics.DrawLine(new Pen(colors[colors.Length - degree], 1), LastX + this.dx, LastY + this.dy, 
                LastX + dx + this.dx, LastY + dy + this.dy);
            LastX += dx;
            LastY += dy;
        }
    }
}
