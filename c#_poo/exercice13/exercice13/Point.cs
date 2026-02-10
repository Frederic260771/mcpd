using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice13
{
    internal class Point
    {
        public double posX { get; set; }
        public double posY { get; set; }

        public Point(double x, double y)
        {
            posX = x;
            posY = y;
        }

        public override string ToString()
        {
            return $"({posX}, {posY})";
        }
    }
}
