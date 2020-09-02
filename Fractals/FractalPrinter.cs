using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    class FractalPrinter
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private int x, y;
        private Color[] COLORS;

        private NestedSpiralSquares squares;
        private H h;
        private CochSnowflake cochSnowflake;
        private TSquare square;
        private Trangle trangle;
        private Hilbert hilbert;
        private SerpinskiTriangle serpinskiTriangle;
        private Gosper gosper;
        private SerpinskiCarpet serpinskiCarpet;
        private QuasiClover quasiClover;

        public FractalPrinter(Graphics graphics, Bitmap bitmap, int x, int y, Color[] colors)
        { 
            this.graphics = graphics;
            this.bitmap = bitmap;
            this.x = x;
            this.y = y;
            this.COLORS = colors;
        }

        public Bitmap DrawCantorSet(int degree)
        { 
            setBitmap();
            float x = this.x / 2 - this.y * 7 / 8 / 2;

            CantorSet cantorSet = new CantorSet(this.y / degree);
            cantorSet.Draw(x, 10, this.x* 7 / 8, graphics, degree);
            return this.bitmap;
        }

        public Bitmap DrawQuasiClover(int degree)
        { 
            setBitmap();
            quasiClover = new QuasiClover();
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            quasiClover.Draw(this.x / 2, 3 * this.y / 5, this.y / 6, 1, degree, graphics, solidBrush);
            return this.bitmap;
        }

        public Bitmap DrawGosper(int degree)
        {
            setBitmap();
            this.gosper = new Gosper();
            this.gosper.Draw(this.x / 16, this.y * 3 / 4, (this.x + this.y) * 2 / 5, 0, degree, 0, graphics, COLORS, degree, 0);
            return this.bitmap;
        }

        public Bitmap DrawSerpinskiCarpet(int degree)
        { 
            setBitmap();
            serpinskiCarpet = new SerpinskiCarpet(this.x, this.y);
            RectangleF carpet = new RectangleF(0, 0, serpinskiCarpet.Width, serpinskiCarpet.Height);
            serpinskiCarpet.Draw(degree, carpet, graphics);

            return this.bitmap;
        }

        public Bitmap DrawSerpinskiTriangle(int degree)
        { 
            setBitmap();
            serpinskiTriangle = new SerpinskiTriangle(this.x, this.y);

            PointF top_point = new PointF(serpinskiTriangle.Width / 2f, 0);
            PointF left_point = new PointF(0, serpinskiTriangle.Height);
            PointF right_point = new PointF(serpinskiTriangle.Width, serpinskiTriangle.Height);

            serpinskiTriangle.Draw(degree , top_point, left_point, right_point, this.graphics, COLORS);
            return this.bitmap;
        }

        public Bitmap DrawHilbert(int degree)
        { 
            setBitmap();
            float start_x, start_y, start_length, total_length;

            if (this.y < this.x){
                total_length = (float)(0.9 * y);
            } else {
                total_length = (float)(0.9 * x);
            }

            start_x = (this.x - total_length) / 2;
            start_y = (this.y - total_length) / 2;

            start_length = (float)(total_length / (Math.Pow(2, degree) - 1));
            hilbert = new Hilbert((int)start_x, (int)start_y);
            hilbert.Draw(this.x, this.y, this.graphics, degree, start_length, COLORS);
            return this.bitmap;
        }

        public Bitmap DrawTrangle(int degree)
        { 
            setBitmap();
            this.trangle = new Trangle();
            this.trangle.Draw(this.x, this.y, this.graphics, degree, COLORS);
            return this.bitmap;
        }

        public Bitmap DrawTSquare(int degree)
        {
            setBitmap();
            square = new TSquare();
            PointF point = new PointF(this.x / 2 - this.y / 4, this.y / 4);
            square.Draw(point, this.y / 2 - this.y / 10, degree, this.graphics);
            return this.bitmap;
        }

        public Bitmap DrawNestedSpiralSquares(int degree)
        {
            setBitmap();
            squares = new NestedSpiralSquares(this.x / 2, this.y / 2);
            squares.Draw(this.x, this.y, degree, this.graphics);
            return this.bitmap;
        }

        public Bitmap DrawH(int degree)
        { 
            setBitmap();
            H h = new H();
            h.Draw(this.x / 2, this.y / 2, (this.x + this.y) / 8, (this.x + this.y) / 8 / degree, graphics, degree, COLORS);
            return this.bitmap;
        }

        public Bitmap DrawCochSnowflake(int degree)
        {
            setBitmap();
            this.cochSnowflake = new CochSnowflake();
            this.cochSnowflake.Draw(this.x, this.y, degree, this.graphics, COLORS);
            return this.bitmap;
        }

        private void setBitmap()
        {
            this.bitmap = new Bitmap(this.x, this.y);
            this.graphics = Graphics.FromImage(this.bitmap);
        }
    }
}
