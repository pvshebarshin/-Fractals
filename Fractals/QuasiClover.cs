using System.Drawing;

namespace Fractals
{
    class QuasiClover
    {
        Color[] colors;
        private readonly int dx;
        private readonly int dy;

        public QuasiClover(Color[] colors, int dx, int dy)
        { 
            this.colors = colors;
            this.dx = dx;
            this.dy = dy;
        }

        public void Draw(int x0, int y0, int r, int delta, int degree, Graphics graphics)
        {
            SolidBrush solidBrush = new SolidBrush(colors[degree == 0 ? 0 : degree - 1]);
            graphics.FillEllipse(solidBrush, x0 - r + dx, y0 - r + dy, 2 * r, 2 * r);
            if (degree == 0)
                return;
            int[] x = new int[4];
            int[] y = new int[4];
            int d = 3 * r / 2;

            x[0] = x0 - d;
            y[0] = y0;
            x[1] = x0;
            y[1] = y0 - d;
            x[2] = x0 + d;
            y[2] = y0;
            x[3] = x0;
            y[3] = y0 + d;

            for (int i = 0; i < 4; i++)
            {
                if (i - delta == 2 || i - delta == -2)
                    continue;
                Draw(x[i], y[i], r / 2, i, degree - 1, graphics);
            }
        }
    }
}
