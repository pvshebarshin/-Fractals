using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        public static Bitmap bitmap;
        public static Graphics graphics;

        static int NUMBER_OF_FRACTAL = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            Trangle trangle = new Trangle();
            Pen pen = new Pen(Color.Black, 1);
            int d = 100;
            Point A = new Point(pictureBox.Width * 3 / 4 + d,
                pictureBox.Height * 3 / 4 - d + 50 + d);
            Point B = new Point(pictureBox.Width / 4 - d,
                pictureBox.Height * 3 / 4 - d + 50 + d);
            Point C = new Point(pictureBox.Width / 2,
                pictureBox.Height / 4 - d + 50);
            graphics.DrawLine(pen, A.X, A.Y, B.X, B.Y);
            graphics.DrawLine(pen, B.X, B.Y, C.X, C.Y);
            graphics.DrawLine(pen, A.X, A.Y, C.X, C.Y);
            trangle.Draw(A, B, C, pen, graphics, trackBar.Value);
            pictureBox.Image = bitmap;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            labelDegree.Text = "Degree: " + trackBar.Value;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Фрактал \"Центр масс треугольника\"":
                    NUMBER_OF_FRACTAL = 1;
                    break;
            }
        }
    }
}
