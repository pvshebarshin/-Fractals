using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    class Serpinski
    {
        private int width;
        private int height;

        public Serpinski(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width {
            get {
                return this.width;
            }
        }

        public int Height {
            get {
                return this.height;
            }
        }
    }
}
