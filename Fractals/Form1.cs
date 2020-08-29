using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        public static Bitmap bitmap;
        public static Graphics graphics;

        public static Color[] colors;
        public static Color beginColor;
        public static Color endColor;

        static int NUMBER_OF_FRACTAL = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            getColors();
            FractalPrinter fractal = new FractalPrinter(graphics, bitmap, pictureBox.Width, pictureBox.Height, colors);
            switch (NUMBER_OF_FRACTAL)
            { 
                case 1:
                    pictureBox.Image = fractal.DrawTrangle(trackBar.Value);
                    break;

                case 2:
                    pictureBox.Image = fractal.DrawCochSnowflake(trackBar.Value);
                    break;

                case 3:
                    pictureBox.Image = fractal.DrawHilbert(trackBar.Value);
                    break;

                case 4:
                    pictureBox.Image = fractal.DrawGosper(trackBar.Value);
                    break;

                case 5:
                    pictureBox.Image = fractal.DrawSerpinskiTriangle(trackBar.Value);
                    break;

                case 6:
                    pictureBox.Image = fractal.DrawSerpinskiCarpet(trackBar.Value);
                    break;

                case 7:
                    pictureBox.Image = fractal.DrawQuasiClover(trackBar.Value);
                    break;

                case 8:
                    pictureBox.Image = fractal.DrawCantorSet(trackBar.Value);
                    break;

                case 9:
                    pictureBox.Image = fractal.DrawTSquare(trackBar.Value);
                    break;

                case 10:
                    pictureBox.Image = fractal.DrawH(trackBar.Value);
                    break;

                case 11:
                    pictureBox.Image = fractal.DrawNestedSpiralSquares(trackBar.Value);
                    break;
            }
            
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
                case "Снежинка Коха":
                    NUMBER_OF_FRACTAL = 2;
                    break;
                case "Кривая Гильберта":
                    NUMBER_OF_FRACTAL = 3;
                    break;
                case "Кривая Госпера":
                    NUMBER_OF_FRACTAL = 4;
                    break;
                case "Треугольник Серпинского":
                    NUMBER_OF_FRACTAL = 5;
                    break;
                case "Ковер Серпинского":
                    NUMBER_OF_FRACTAL = 6;
                    break;
                case "Фрактал \"Квазиклевер\"":
                    NUMBER_OF_FRACTAL = 7;
                    break;
                case "Множество Кантора":
                    NUMBER_OF_FRACTAL = 8;
                    break;
                case "Т-Фрактал":
                    NUMBER_OF_FRACTAL = 9;
                    break;
                case "Н-фрактал":
                    NUMBER_OF_FRACTAL = 10;
                    break;
                case "Вложенные спиральные квадраты":
                    NUMBER_OF_FRACTAL = 11;
                    break;
                default:
                    NUMBER_OF_FRACTAL = 2;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.Text = "Снежинка Коха";
        }

        private void colorButtonBegin_Click(object sender, EventArgs e)
        {
            if (colorDialogBegin.ShowDialog() == DialogResult.Cancel)
                return;
            beginColor = colorDialogBegin.Color;
        }

        private void colorButtonEnd_Click(object sender, EventArgs e)
        {
            if (colorDialogEnd.ShowDialog() == DialogResult.Cancel)
                return;
            endColor = colorDialogEnd.Color;
        }

        private void getColors() 
        {
            int rMin = beginColor.R;
            int rMax = endColor.R;

            int gMin = beginColor.G;
            int gMax = endColor.G;

            int bMin = beginColor.B;
            int bMax = endColor.B;
            
            colors = new Color[trackBar.Value];
            colors[0] = beginColor;
            if(colors.Length > 1)
                colors[colors.Length - 1] = endColor;

            if(colors.Length > 2)
            { 
                int rAverage, gAverage, bAverage;
                for (int i = 1; i < colors.Length - 1; i++)
                {
                    rAverage = colors[i - 1].R + (rMax - rMin) / colors.Length;
                    gAverage = colors[i - 1].G + (gMax - gMin) / colors.Length;
                    bAverage = colors[i - 1].B + (bMax - bMin) / colors.Length;
                    colors[i] = Color.FromArgb(rAverage, gAverage, bAverage);
                }
            }
        }
    }
}
