using System.Drawing;

namespace Fractals
{
    class Serpinski
    {
        protected int width;
        protected int height;
        protected Color[] colors;

        public Serpinski(int width, int height, Color[] colors)
        {
            this.width = width;
            this.height = height;
            this.colors = colors;
        }

        public int Width {
            get {
                return width;
            }
        }

        public int Height {
            get {
                return height;
            }
        }
    }
}
