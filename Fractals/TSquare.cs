using System.Drawing;

namespace Fractals
{
    class TSquare
    {
        private Color[] colors;
        public TSquare(Color[] colors)
        {
            this.colors = colors;
        }

        public void Draw(PointF A, int size, int degree, Graphics graphics)
        {
            Brush brush = new SolidBrush(colors[degree - 1]);

            if (degree == 1)
            {
                graphics.FillRectangle(brush, A.X, A.Y, size, size);
                return;
            }

            int delta = size / 4;
            PointF[] points = new PointF[4];

            for (int i = 0; i < 4; i++)
                points[i] = new PointF();

            points[0].X = A.X - delta;
            points[0].Y = A.Y - delta;

            points[1].X = A.X - delta;
            points[1].Y = A.Y + size - delta;

            points[2].X = A.X + size - delta;
            points[2].Y = A.Y - delta;

            points[3].X = A.X + size - delta;
            points[3].Y = A.Y + size - delta;

            for (int i = 0; i < 4; i++)
                Draw(points[i], size / 2, degree - 1, graphics);
            graphics.FillRectangle(brush, A.X, A.Y, size, size);

            return;
        }
    }
}
