using System;
using System.Drawing;

namespace Fractals
{
    class Gosper
    {
        private Color[] colors;
        private readonly int dx;
        private readonly int dy;

        public Gosper(Color[] colors, int dx, int dy)
        { 
            this.colors = colors;
            this.dx = dx;
            this.dy = dy;
        }

        public void Draw(double x, double y, double length, double u, 
            int degree, int q, Graphics graphics)
        {
            if (degree > 0)
            {
                if (q == 1)
                {
                    x += length * Math.Cos(u);
                    y -= length * Math.Sin(u);
                    u += Math.PI;
                }
                u -= 2 * Math.PI / 19;
                length /= Math.Sqrt(7);
                Draw(ref x, ref y, length, u, degree - 1, 0, graphics);
                Draw(ref x, ref y, length, u + Math.PI / 3, degree - 1, 1, graphics);
                Draw(ref x, ref y, length, u + Math.PI, degree - 1, 1, graphics);
                Draw(ref x, ref y, length, u + 2 * Math.PI / 3, degree - 1, 0, graphics);
                Draw(ref x, ref y, length, u, degree - 1, 0, graphics);
                Draw(ref x, ref y, length, u, degree - 1, 0, graphics);
                Draw(ref x, ref y, length, u - Math.PI / 3, degree - 1, 1, graphics);
            } else {
                graphics.DrawLine(new Pen(colors[degree], 1), (float)Math.Round(x) + dx, 
                    (float)Math.Round(y) + dy, (float)Math.Round(x + Math.Cos(u) * length) + dx, 
                    (float)Math.Round(y - Math.Sin(u) * length) + dy);
            }
        }

        private void Draw(ref double x, ref double y, double length, 
            double u, int t, int q, Graphics graphics)
        {
            Draw(x, y, length, u, t, q, graphics);
            x += length * Math.Cos(u);
            y -= length * Math.Sin(u);
        }
    }
}
