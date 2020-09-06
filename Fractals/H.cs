using System.Drawing;

namespace Fractals
{
    class H
    {
        private Color[] colors;

        public H(Color[] colors)
        { 
            this.colors = colors;
        }

        public void Draw(int x1, int y1, int size, int minimum, Graphics graphics, int iter)
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

            printH(x1, y1, size, graphics, iter);
            size /= 2;
            iter--;
            if (iter > 0)
            {
                Draw(x11, y11, size, minimum, graphics, iter);
                Draw(x01, y01, size, minimum, graphics, iter);
                Draw(x10, y10, size, minimum, graphics, iter);
                Draw(x00, y00, size, minimum, graphics, iter);
            }
        }

        private void printH(int x, int y, int size, Graphics graphics, int index)
        {
            Pen pen = new Pen(colors[colors.Length - index], 1);
            graphics.DrawLine(pen, x - size, y - size, x - size, y + size);
            graphics.DrawLine(pen, x - size, y, x + size, y);
            graphics.DrawLine(pen, x + size, y - size, x + size, y + size);
        }
    }
}
