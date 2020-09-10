using System;
using System.Drawing;

namespace Fractals
{
    class FractalPrinter
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private readonly int x, y;
        private readonly Color[] COLORS;
        private readonly int dx;
        private readonly int dy;

        public Graphics Graphics { get => graphics; set => graphics = value; }
        public Bitmap Bitmap { get => bitmap; set => bitmap = value; }

        public FractalPrinter(Graphics graphics, Bitmap bitmap, int x, int y, Color[] colors, int dx, int dy)
        { 
            this.Graphics = graphics;
            this.Bitmap = bitmap;
            this.x = x;
            this.y = y;
            COLORS = colors;
            this.dx = dx;
            this.dy = dy;
        }

        public Bitmap DrawCantorSet(int degree)
        { 
            setBitmap();
            float x = this.x / 2 - y * 7 / 8 / 2;

            CantorSet cantorSet = new CantorSet(y / degree, COLORS, dx, dy);
            cantorSet.Draw(x, 10, this.x * 7 / 8, Graphics, degree);
            return Bitmap;
        }

        public Bitmap DrawQuasiClover(int degree)
        { 
            setBitmap();
            QuasiClover quasiClover = new QuasiClover(COLORS, dx, dy);
            quasiClover.Draw(x / 2, 3 * y / 5, y / 6, 1, degree, Graphics);
            return Bitmap;
        }

        public Bitmap DrawGosper(int degree)
        {
            setBitmap();
            Gosper gosper = new Gosper(COLORS, dx, dy);
            gosper.Draw(x / 16, y * 3 / 4, (x + y) * 2 / 5, 0, degree, 0, Graphics);
            return Bitmap;
        }

        public Bitmap DrawSerpinskiCarpet(int degree)
        { 
            setBitmap();
            SerpinskiCarpet serpinskiCarpet = new SerpinskiCarpet(x, y, COLORS);
            RectangleF carpet = new RectangleF(0 + dx, 0 + dy, serpinskiCarpet.Width, serpinskiCarpet.Height);
            serpinskiCarpet.Draw(degree, carpet, Graphics);

            return Bitmap;
        }

        public Bitmap DrawSerpinskiTriangle(int degree)
        { 
            setBitmap();
            SerpinskiTriangle serpinskiTriangle = new SerpinskiTriangle(x, y, COLORS);

            PointF top_point = new PointF(serpinskiTriangle.Width / 2f + dx, 0 + dy);
            PointF left_point = new PointF(0 + dx, serpinskiTriangle.Height + dy);
            PointF right_point = new PointF(serpinskiTriangle.Width + dx, serpinskiTriangle.Height + dy);

            serpinskiTriangle.Draw(degree , top_point, left_point, right_point, Graphics);
            return Bitmap;
        }

        public Bitmap DrawHilbert(int degree)
        { 
            setBitmap();
            float start_x, start_y, start_length, total_length;

            if (y < x){
                total_length = (float)(0.9 * y);
            } else {
                total_length = (float)(0.9 * x);
            }

            start_x = (x - total_length) / 2;
            start_y = (y - total_length) / 2;

            start_length = (float)(total_length / (Math.Pow(2, degree) - 1));
            Hilbert hilbert = new Hilbert((int)start_x, (int)start_y, COLORS, dx, dy);
            hilbert.Draw(Graphics, degree, start_length);
            return Bitmap;
        }

        public Bitmap DrawTrangle(int degree)
        { 
            setBitmap();
            Trangle trangle = new Trangle(COLORS, dx, dy);
            trangle.Draw(x, y, Graphics, degree);
            return Bitmap;
        }

        public Bitmap DrawTSquare(int degree)
        {
            setBitmap();
            TSquare square = new TSquare(COLORS);
            PointF point = new PointF(x * 5 / 16 + dx, y * 5 / 16 + dy);
            square.Draw(point, y / 2 - y / 10, degree, Graphics);
            return Bitmap;
        }

        public Bitmap DrawNestedSpiralSquares(int degree)
        {
            setBitmap();
            NestedSpiralSquares squares = new NestedSpiralSquares(x / 2, y / 2, COLORS, dx, dy);
            squares.Draw(x, y, degree, Graphics);
            return Bitmap;
        }

        public Bitmap DrawH(int degree)
        { 
            setBitmap();
            H h = new H(COLORS);
            h.Draw(x / 2 + dx, y / 2 + dy, (x + y) / 8, (x + y) / 8 / degree, Graphics, degree);
            return Bitmap;
        }

        public Bitmap DrawCochSnowflake(int degree)
        {
            setBitmap();
            CochSnowflake cochSnowflake = new CochSnowflake(COLORS, dx, dy);
            cochSnowflake.Draw(x, y, degree, Graphics);
            return Bitmap;
        }

        private void setBitmap()
        {
            this.Bitmap = new Bitmap(this.x, this.y);
            this.Graphics = Graphics.FromImage(this.Bitmap);
        }
    }
}
