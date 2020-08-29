using System.Drawing;

namespace Fractals
{
    class Trangle
    {
        private void DrawR(Point A, Point B, Point C, 
            Pen pen, Graphics graphics, int degree, Color[] colors)
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
                DrawR(A, B, D, pen, graphics, degree, colors);
                DrawR(B, C, D, pen, graphics, degree, colors);
                DrawR(A, C, D, pen, graphics, degree, colors);
            }
        }

        public void Draw(int x, int y, Graphics graphics, int degree, Color[] colors)
        {
            Pen pen = new Pen(colors[0], 1);
            int delta = 100;

            Point A = new Point(x * 3 / 4 + delta, y * 3 / 4 + 50);
            Point B = new Point(x / 4 - delta, y * 3 / 4 + 50);
            Point C = new Point(x / 2, x / 4 - delta + 50);

            graphics.DrawLine(pen, A.X, A.Y, B.X, B.Y);
            graphics.DrawLine(pen, B.X, B.Y, C.X, C.Y);
            graphics.DrawLine(pen, A.X, A.Y, C.X, C.Y);
            DrawR(A, B, C, pen, graphics, degree, colors);
        }
    }
}
