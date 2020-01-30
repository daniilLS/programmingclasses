using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Geometry
    {
        private double _x;
        private double _y;
        public double X => _x;
        public double Y => _y;

        public Geometry()
        {
            _x = 0;
            _y = 0;

        }
        public Geometry(double z)
        {
            _x = z;
            _y = z;
        }
        public Geometry(double x,double y)
        {
            _x = x;
            _y = y;

        }
    }
}
