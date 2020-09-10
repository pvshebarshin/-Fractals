using System;
using System.Drawing;

namespace Fractals
{
    class NestedSpiralSquares
    {
        private readonly double x0;
        private readonly double y0;
        private readonly Color[] colors;
        private readonly int dx;
        private readonly int dy;

        public NestedSpiralSquares(double x0, double y0, Color[] colors, int dx, int dy)
        { 
            this.x0 = x0;
            this.y0 = y0;
            this.colors = colors;
            this.dx = dx;
            this.dy = dy;
        }

        private void Draw(double k, double b, Graphics graphics, int degree)
        {
            int x1, x2, x3, x4, 
                y1, y2, y3, y4;
            Pen myPen = new Pen(colors[degree], 1);

            x1 = (int)(x0 + k * Math.Cos(b + 1 * Math.PI / 4));
            y1 = (int)(y0 + k * Math.Sin(b + 1 * Math.PI / 4));
            x2 = (int)(x0 + k * Math.Cos(b + 3 * Math.PI / 4));
            y2 = (int)(y0 + k * Math.Sin(b + 3 * Math.PI / 4));
            x3 = (int)(x0 + k * Math.Cos(b + 5 * Math.PI / 4));
            y3 = (int)(y0 + k * Math.Sin(b + 5 * Math.PI / 4));
            x4 = (int)(x0 + k * Math.Cos(b + 7 * Math.PI / 4));
            y4 = (int)(y0 + k * Math.Sin(b + 7 * Math.PI / 4));

            graphics.DrawPolygon(myPen, new Point[] 
            {
                new Point(x1 + dx, y1 + dy), new Point(x2 + dx, y2 + dy),
                new Point(x3 + dx, y3 + dy), new Point(x4 + dx, y4 + dy),
            });
        }

        public void Draw(int x, int y, int degree, Graphics graphics)
        {
            double lenght = (x + y) / 3, 
                shift = 0;

            for (int i = 0; i < degree; i++)
            {
                Draw(lenght, shift, graphics, i);
                shift += Math.PI / 19;
                lenght *= Math.Sin(Math.PI / 3);
            }
        }
    }
}
