using System.Drawing;

namespace Fractals
{
    class H
    {
        public void Draw(int x1, int y1, int size, int minimum, Graphics graphics, int iter, Color[] colors)
        {
            int x11, y11;
            int x01, y01;
            int x00, y00;
            int x10, y10;

            x11 = x1 + size;
            y11 = y1 + size;
            x01 = x1 - size;
            y01 = y1 + size;
            x10 = x1 + size;
            y10 = y1 - size;
            x00 = x1 - size;
            y00 = y1 - size;

            printH(x1, y1, size, graphics, colors, iter);
            size /= 2;
            iter--;
            if (iter > 0)
            {
                Draw(x11, y11, size, minimum, graphics, iter, colors);
                Draw(x01, y01, size, minimum, graphics, iter, colors);
                Draw(x10, y10, size, minimum, graphics, iter, colors);
                Draw(x00, y00, size, minimum, graphics, iter, colors);
            }
        }

        private void printH(int x, int y, int size, Graphics graphics, Color[] colors, int index)
        {
            Pen pen = new Pen(colors[colors.Length - index], 1);
            graphics.DrawLine(pen, x - size, y - size, x - size, y + size);
            graphics.DrawLine(pen, x - size, y, x + size, y);
            graphics.DrawLine(pen, x + size, y - size, x + size, y + size);
        }
    }
}
