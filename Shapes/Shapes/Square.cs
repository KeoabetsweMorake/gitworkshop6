using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }

        public Square()
        {

        }

        public Square(double length, double width)
        {
            Lenght = length;
            Width = width;
        }

        public void CalcArea()
        {
            Area = Lenght * Width;
            Console.Write($"The Area of the Square is {Area}");
        }
    }
}
