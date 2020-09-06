using System;
using System.Drawing;

namespace Fractals
{
    class FractalPrinter
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private int x, y;
        private Color[] COLORS;

        public FractalPrinter(Graphics graphics, Bitmap bitmap, int x, int y, Color[] colors)
        { 
            this.graphics = graphics;
            this.bitmap = bitmap;
            this.x = x;
            this.y = y;
            COLORS = colors;
        }

        public Bitmap DrawCantorSet(int degree)
        { 
            setBitmap();
            float x = this.x / 2 - y * 7 / 8 / 2;

            CantorSet cantorSet = new CantorSet(y / degree, COLORS);
            cantorSet.Draw(x, 10, this.x * 7 / 8, graphics, degree);
            return bitmap;
        }

        public Bitmap DrawQuasiClover(int degree)
        { 
            setBitmap();
            QuasiClover quasiClover = new QuasiClover(COLORS);
            quasiClover.Draw(x / 2, 3 * y / 5, y / 6, 1, degree, graphics);
            return bitmap;
        }

        public Bitmap DrawGosper(int degree)
        {
            setBitmap();
            Gosper gosper = new Gosper(COLORS);
            gosper.Draw(x / 16, y * 3 / 4, (x + y) * 2 / 5, 0, degree, 0, graphics);
            return bitmap;
        }

        public Bitmap DrawSerpinskiCarpet(int degree)
        { 
            setBitmap();
            SerpinskiCarpet serpinskiCarpet = new SerpinskiCarpet(x, y, COLORS);
            RectangleF carpet = new RectangleF(0, 0, serpinskiCarpet.Width, serpinskiCarpet.Height);
            serpinskiCarpet.Draw(degree, carpet, graphics);

            return bitmap;
        }

        public Bitmap DrawSerpinskiTriangle(int degree)
        { 
            setBitmap();
            SerpinskiTriangle serpinskiTriangle = new SerpinskiTriangle(x, y, COLORS);

            PointF top_point = new PointF(serpinskiTriangle.Width / 2f, 0);
            PointF left_point = new PointF(0, serpinskiTriangle.Height);
            PointF right_point = new PointF(serpinskiTriangle.Width, serpinskiTriangle.Height);

            serpinskiTriangle.Draw(degree , top_point, left_point, right_point, graphics);
            return bitmap;
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
            Hilbert hilbert = new Hilbert((int)start_x, (int)start_y, COLORS);
            hilbert.Draw(x, y, graphics, degree, start_length);
            return bitmap;
        }

        public Bitmap DrawTrangle(int degree)
        { 
            setBitmap();
            Trangle trangle = new Trangle(COLORS);
            trangle.Draw(x, y, graphics, degree);
            return bitmap;
        }

        public Bitmap DrawTSquare(int degree)
        {
            setBitmap();
            TSquare square = new TSquare(COLORS);
            PointF point = new PointF(x / 2 - y / 4, y / 4);
            square.Draw(point, y / 2 - y / 10, degree, graphics);
            return this.bitmap;
        }

        public Bitmap DrawNestedSpiralSquares(int degree)
        {
            setBitmap();
            NestedSpiralSquares squares = new NestedSpiralSquares(x / 2, y / 2, COLORS);
            squares.Draw(x, y, degree, graphics);
            return bitmap;
        }

        public Bitmap DrawH(int degree)
        { 
            setBitmap();
            H h = new H(COLORS);
            h.Draw(x / 2, y / 2, (x + y) / 8, (x + y) / 8 / degree, graphics, degree);
            return bitmap;
        }

        public Bitmap DrawCochSnowflake(int degree)
        {
            setBitmap();
            CochSnowflake cochSnowflake = new CochSnowflake(COLORS);
            cochSnowflake.Draw(x, y, degree, graphics);
            return bitmap;
        }

        private void setBitmap()
        {
            this.bitmap = new Bitmap(this.x, this.y);
            this.graphics = Graphics.FromImage(this.bitmap);
        }
    }
}
