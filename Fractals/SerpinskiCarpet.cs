using System.Drawing;

namespace Fractals
{
    class SerpinskiCarpet : Serpinski
    {
        public SerpinskiCarpet(int width, int height) : base(width, height)
        {

        }

        public void Draw(int degree, RectangleF rectangle, Graphics graphics)
        {
            if (degree == 0) {
                graphics.FillRectangle(Brushes.Black, rectangle);
            } else {
                float width = rectangle.Width / 3f;
                float height = rectangle.Height / 3f;

                float x1 = rectangle.Left;
                float x2 = x1 + width;
                float x3 = x1 + 2f * width;

                float y1 = rectangle.Top;
                float y2 = y1 + height;
                float y3 = y1 + 2f * height;

                Draw(degree - 1, new RectangleF(x1, y1, width, height), graphics);
                Draw(degree - 1, new RectangleF(x2, y1, width, height), graphics);
                Draw(degree - 1, new RectangleF(x3, y1, width, height), graphics);
                Draw(degree - 1, new RectangleF(x1, y2, width, height), graphics);
                Draw(degree - 1, new RectangleF(x3, y2, width, height), graphics);
                Draw(degree - 1, new RectangleF(x1, y3, width, height), graphics);
                Draw(degree - 1, new RectangleF(x2, y3, width, height), graphics);
                Draw(degree - 1, new RectangleF(x3, y3, width, height), graphics);
            }
        }
    }
}
