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

        public void Draw(int x, int y, Graphics graphics, int degree, float start_length, Color[] colors)
        { 
            DrawR(degree, start_length, 0, graphics, colors);
        }

        private void DrawR(int degree, float dx, float dy, Graphics graphics, Color[] colors)
        {
            if (degree > 1)
                DrawR(degree - 1, dy, dx, graphics, colors);
            Drawing(graphics, dx, dy, degree, colors);

            if (degree > 1)
                DrawR(degree - 1, dx, dy, graphics, colors);
            Drawing(graphics, dy, dx, degree, colors);

            if (degree > 1)
                DrawR(degree - 1, dx, dy, graphics, colors);
            Drawing(graphics, -dx, -dy, degree, colors);

            if (degree > 1)
                DrawR(degree - 1, -dy, -dx, graphics, colors);
        }

        private void Drawing(Graphics graphics, float dx, float dy, int degree, Color[] colors)
        {
            graphics.DrawLine(new Pen(colors[colors.Length - degree], 1), LastX, LastY, LastX + dx, LastY + dy);
            this.LastX += dx;
            this.LastY += dy;
        }
    }
}
