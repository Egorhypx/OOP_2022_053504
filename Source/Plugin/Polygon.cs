using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using DomainModel; 

namespace Plugin
{
    public class Polygon : Element
    {
        private int anglescount;
        private Point center;
        private int anglestep;
        private int radius;

        public override void UpdateOnMouseMove(int x, int y)
        {
            PosX2 = x;
            PosY2 = y;
            center = new Point(PosX1 + (PosX2 - PosX1) / 2, PosY1 + (PosY2 - PosY1) / 2);
            anglestep = 360 / anglescount;
            radius = (PosX2 - PosX1) / 2;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            SolidBrush brush = new SolidBrush(FillColor);
            SolidBrush clearbrush = new SolidBrush(Color.White);
            
            
            List<Point> points = new List<Point>();

            int angle = 0;

            for (int i = 0; i < anglescount; i++)
            {
                Point pt = new Point
                {
                    X = (int)(center.X + radius * Math.Sin(ToRadians(angle))),
                    Y = (int)(center.Y + radius * Math.Cos(ToRadians(angle)))
                };

                angle += anglestep;
                points.Add(pt);
            }

            g.DrawPolygon(pen, points.ToArray());

            if (IsFillNull == false)
                g.FillPolygon(brush, points.ToArray());

            if (IsErased == true)
                g.FillPolygon(clearbrush, points.ToArray());

        }

        public Polygon()
        {
            anglescount = 5;
        }

        static double ToRadians(int degrees)
        {
            return degrees / 180.0 * Math.PI;
        }
    }
}
