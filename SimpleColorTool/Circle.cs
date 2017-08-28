using System;
using System.Drawing;

namespace SimpleColorTool
{
    class Circle
    {
        public Point Middle { get; set; }
        public double Radius { get; set; }

        public Circle(Point middle, double radius)
        {
            Middle = middle;
            Radius = radius;
        }

        public bool IsPointInCircle(Point point)
        {
            double d = Math.Pow(point.X - Middle.X, 2) + Math.Pow(point.Y - Middle.Y, 2);
            d = Math.Sqrt(d);

            return (d <= Radius);
        }
    }
}
