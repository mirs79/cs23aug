using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeProject
{
   

    class Point
    {
        public double x;
        public double y;

        public static String print(Point p)
        {
            return "Координаты точки (" + p.x +"," +p.y + ")";
        }

        public static double distanceBetween(Point a, Point b)
        {
            double dx = b.x - a.x;
            double dy = b.y - a.y;
            double dist = Math.Sqrt(dx*dx+ dy*dy);
            return dist;
        }

        public double distanceTo(Point p)
        {
            double dx = p.x - this.x;
            double dy = p.y - this.y;
            double dist = Math.Sqrt(dx * dx + dy * dy);
            return dist;
        }

    }
}
