using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    class Trangle
    {
        public void Draw(Point A, Point B, Point C, 
            Pen pen, Graphics graphics, int depth)
        {
            //Параметры: точки А В С начального треугольника и кол-во итераций iter
            Point D = new Point();    //Точка центра масс
            Point v1 = new Point();   //Вектор AB
            Point v2 = new Point();   //Вектор AC
            v1.X = B.X - A.X;
            v1.Y = B.Y - A.Y;
            v2.X = C.X - A.X;
            v2.Y = C.Y - A.Y;
            D.X = A.X + (v1.X + v2.X) / 3;     //К точке А прибавим сумму векторов AВ и AC, деленную на 3
            D.Y = A.Y + (v1.Y + v2.Y) / 3; 
            //и получим координаты центра масс
            pen = new Pen(Color.Black, 1);
            graphics.DrawLine(pen, A.X, A.Y, D.X, D.Y);    //Рисуем отрезки от вершин к центру масс
            graphics.DrawLine(pen, B.X, B.Y, D.X, D.Y);
            graphics.DrawLine(pen, C.X, C.Y, D.X, D.Y);

            if (depth > 1)
            {
                depth--;
                Draw(A, B, D, pen, graphics, depth);
                Draw(B, C, D, pen, graphics, depth);
                Draw(A, C, D, pen, graphics, depth);
            }
        }
    }
}
