using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        double h;
        double r;
        public double CylinderVolume(double h, double r)
        {
            double result = Math.PI * Math.Pow(r, 2) * h;
            return result;
        }
    }
}
