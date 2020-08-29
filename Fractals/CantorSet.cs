using System.Drawing;

namespace Fractals
{
    class CantorSet
    {
        private int h;

        public CantorSet(int h)
        { 
            this.h = h;
        }

        public void Draw(float x, float y, float width, Graphics graphics, int dep)
        {
            SolidBrush Black = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black, 0.1f);

            if (dep > 0)
            {
                graphics.DrawRectangle(myPen, x, y, width, 12);
                graphics.FillRectangle(Black, x, y, width, 12);

                y += this.h;

                Draw(x + width * 2 / 3, y, width / 3, graphics, dep - 1);
                Draw(x, y, width / 3, graphics, dep - 1);
            }
        }
    }
}
