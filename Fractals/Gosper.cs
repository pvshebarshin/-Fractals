﻿using System;
using System.Drawing;

namespace Fractals
{
    class Gosper
    {
        public void Draw(double x, double y, double length, double u, int t, int q, Graphics graphics)
        {
            if (t > 0)
            {
                if (q == 1)
                {
                    x += length * Math.Cos(u);
                    y -= length * Math.Sin(u);
                    u += Math.PI;
                }
                u -= 2 * Math.PI / 19;
                length /= Math.Sqrt(7);

                Draw(ref x, ref y, length, u, t - 1, 0, graphics);
                Draw(ref x, ref y, length, u + Math.PI / 3, t - 1, 1, graphics);
                Draw(ref x, ref y, length, u + Math.PI, t - 1, 1, graphics);
                Draw(ref x, ref y, length, u + 2 * Math.PI / 3, t - 1, 0, graphics);
                Draw(ref x, ref y, length, u, t - 1, 0, graphics);
                Draw(ref x, ref y, length, u, t - 1, 0, graphics);
                Draw(ref x, ref y, length, u - Math.PI / 3, t - 1, 1, graphics);
            } else {
                graphics.DrawLine(new Pen(Color.Black, 1), (float)Math.Round(x), 
                    (float)Math.Round(y), (float)Math.Round(x + Math.Cos(u) * length), 
                    (float)Math.Round(y - Math.Sin(u) * length));
            }
        }

        private void Draw(ref double x, ref double y, double length, 
            double u, int t, int q, Graphics graphics)
        {
            Draw(x, y, length, u, t, q, graphics);
            x += length * Math.Cos(u);
            y -= length * Math.Sin(u);
        }
    }
}
