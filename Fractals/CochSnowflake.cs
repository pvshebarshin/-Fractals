using System.Drawing;

namespace Fractals
{
    class CochSnowflake
    {
        private Color[] colors;

        public CochSnowflake(Color[] colors)
        { 
            this.colors = colors;
        }

        private int RDraw(PointF point1, PointF point2, PointF point3, int iter, 
            Graphics graphics)
        {
            if (iter > 0)
            {
                PointF point4 = new PointF((point2.X + 2 * point1.X) / 3, (point2.Y + 2 * point1.Y) / 3);
                PointF point5 = new PointF((2 * point2.X + point1.X) / 3, (point1.Y + 2 * point2.Y) / 3);
                PointF point6 = new PointF((point2.X + point1.X) / 2, (point2.Y + point1.Y) / 2);
                PointF point7 = new PointF((4 * point6.X - point3.X) / 3, (4 * point6.Y - point3.Y) / 3);

                Pen pen = new Pen(colors[colors.Length - iter], 1);
                graphics.DrawLine(pen, point4, point7);
                graphics.DrawLine(pen, point5, point7);
                graphics.DrawLine(pen, point4, point5);

                RDraw(point4, point7, point5, iter - 1, graphics);
                RDraw(point7, point5, point4, iter - 1, graphics);
                RDraw(point1, point4, new PointF((2 * point1.X + point3.X) / 3, 
                    (2 * point1.Y + point3.Y) / 3), iter - 1, graphics);
                RDraw(point5, point2, new PointF((2 * point2.X + point3.X) / 3, 
                    (2 * point2.Y + point3.Y) / 3), iter - 1, graphics);
            }
            return iter;
        }

        public void Draw(int x, int y, int degree, Graphics graphics) 
        {
            Pen pen = new Pen(colors[0], 1);

            PointF point1 = new PointF(x / 8, y / 4);
            PointF point2 = new PointF(x / 8 + y * 6 / 8, y / 4);
            PointF point3 = new PointF(x / 2, y * 7 / 8);

            graphics.DrawLine(pen, point1, point2);
            graphics.DrawLine(pen, point2, point3);
            graphics.DrawLine(pen, point3, point1);

            RDraw(point1, point2, point3, degree, graphics);
            RDraw(point2, point3, point1, degree, graphics);
            RDraw(point3, point1, point2, degree, graphics);
        }
    }
}
