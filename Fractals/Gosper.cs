using System;
using System.Drawing;

namespace Fractals
{
    class Gosper
    {
        public void Draw(double x, double y, double length, double u, 
            int degree, int q, Graphics graphics, Color[] colors, int index, int count)
        {
            int need = colors.Length - degree;
            //index = colors.Length - ++count;
            if (degree > 0)
            {
                if (q == 1)
                {
                    x += length * Math.Cos(u);
                    y -= length * Math.Sin(u);
                    u += Math.PI;
                }
                count++;
                u -= 2 * Math.PI / 19;
                length /= Math.Sqrt(7);
                Draw(ref x, ref y, length, u, degree - 1, 0, graphics, colors, colors.Length - count, count);
                Draw(ref x, ref y, length, u + Math.PI / 3, degree - 1, 1, graphics, colors, colors.Length - count, count);
                Draw(ref x, ref y, length, u + Math.PI, degree - 1, 1, graphics, colors, colors.Length - count, count);
                Draw(ref x, ref y, length, u + 2 * Math.PI / 3, degree - 1, 0, graphics, colors, colors.Length - count, count);
                Draw(ref x, ref y, length, u, degree - 1, 0, graphics, colors, colors.Length - count, count);
                Draw(ref x, ref y, length, u, degree - 1, 0, graphics, colors, colors.Length - count, count);
                Draw(ref x, ref y, length, u - Math.PI / 3, degree - 1, 1, graphics, colors, colors.Length - count, count);
            } else {
                graphics.DrawLine(new Pen(colors[index], 1), (float)Math.Round(x), 
                    (float)Math.Round(y), (float)Math.Round(x + Math.Cos(u) * length), 
                    (float)Math.Round(y - Math.Sin(u) * length));
            }
        }

        private void Draw(ref double x, ref double y, double length, 
            double u, int t, int q, Graphics graphics, Color[] colors, int index, int count)
        {
            Draw(x, y, length, u, t, q, graphics, colors, index, count);
            x += length * Math.Cos(u);
            y -= length * Math.Sin(u);
        }
    }
}
