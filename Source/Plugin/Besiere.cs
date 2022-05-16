using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using DomainModel;

namespace Plugin
{
    public class Besiere : Element
    {
        List<PointF> points = new List<PointF>();
        public override void UpdateOnMouseMove(int x, int y)
        {
            points.Add(new PointF(x, y));
        }

        public override void Draw(Graphics g, Pen pen)
        {
            if (points.Count > 1)
                g.DrawCurve(pen, points.ToArray());
        }

        public Besiere()
        {

        }
    }
}