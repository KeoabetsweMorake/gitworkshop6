using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle
    {
        private const double PI = 22 / 7;

        public double radius { get; set; }
        public void Area(double radius)
        {
            System.Console.WriteLine(PI * (radius * radius));
        }
    }
}
