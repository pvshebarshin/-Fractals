using System.Drawing;

namespace Fractals
{
    class TSquare
    {
        public void Draw(PointF A, int size, int iter, Graphics graphics)
        {
            Brush br = new SolidBrush(Color.Red);

            if (iter == 1)
            {
                graphics.FillRectangle(br, A.X, A.Y, size, size);
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
                Draw(points[i], size / 2, iter - 1, graphics);
            graphics.FillRectangle(br, A.X, A.Y, size, size);

            return;
        }
    }
}
