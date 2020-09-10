using System.Drawing;

namespace Fractals
{
    class Trangle
    {
        private Color[] colors;
        private int dx, dy;

        public Trangle(Color[] colors, int dx, int dy)
        {
            this.colors = colors;
            this.dx = dx;
            this.dy = dy;
        }

        private void DrawR(Point A, Point B, Point C, 
            Pen pen, Graphics graphics, int degree)
        {
            Point D = new Point();
            Point v1 = new Point();
            Point v2 = new Point();
            v1.X = B.X - A.X;
            v1.Y = B.Y - A.Y;
            v2.X = C.X - A.X;
            v2.Y = C.Y - A.Y;
            D.X = A.X + (v1.X + v2.X) / 3;
            D.Y = A.Y + (v1.Y + v2.Y) / 3; 

            pen = new Pen(colors[colors.Length - degree], 1);
            graphics.DrawLine(pen, A.X, A.Y, D.X, D.Y);
            graphics.DrawLine(pen, B.X, B.Y, D.X, D.Y);
            graphics.DrawLine(pen, C.X, C.Y, D.X, D.Y);

            if (degree > 1)
            {
                degree--;
                DrawR(A, B, D, pen, graphics, degree);
                DrawR(B, C, D, pen, graphics, degree);
                DrawR(A, C, D, pen, graphics, degree);
            }
        }

        public void Draw(int x, int y, Graphics graphics, int degree)
        {
            Pen pen = new Pen(colors[0], 1);
            int delta = 100;

            Point A = new Point(x * 3 / 4 + delta + dx, y * 3 / 4 + 50 + dy);
            Point B = new Point(x / 4 - delta + dx, y * 3 / 4 + 50 + dy);
            Point C = new Point(x / 2 + dx, x / 4 - delta + 50 + dy);

            graphics.DrawLine(pen, A.X, A.Y, B.X, B.Y);
            graphics.DrawLine(pen, B.X, B.Y, C.X, C.Y);
            graphics.DrawLine(pen, A.X, A.Y, C.X, C.Y);
            DrawR(A, B, C, pen, graphics, degree);
        }
    }
}
