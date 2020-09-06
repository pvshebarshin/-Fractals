using System.Drawing;

namespace Fractals
{
    class SerpinskiTriangle : Serpinski
    {
        public SerpinskiTriangle(int width, int height, Color[] colors) : base(width, height, colors)
        { 

        }

        public void Draw(int degree, PointF top, PointF left, PointF right, Graphics graphics)
        {
            if (degree == 0) {
                PointF[] points = new PointF[3]{ top, right, left };
                SolidBrush brush = new SolidBrush(colors[degree]);
                graphics.FillPolygon(brush, points);
            } else {
                PointF left_mid = MidPoint(top, left);
                PointF right_mid = MidPoint(top, right);
                PointF top_mid = MidPoint(left, right);

                Draw(degree - 1, top, left_mid, right_mid, graphics);
                Draw(degree - 1, left_mid, left, top_mid, graphics);
                Draw(degree - 1, right_mid, top_mid, right, graphics);
            }
        }

        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }

    }
}
