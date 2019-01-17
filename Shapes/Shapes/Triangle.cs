using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle
    {
        private int intBase;
        private int intHeight;
        private double dblArea;

        public Triangle(int intBase, int intHeight)
        {
            this.IntBase = intBase;
            this.IntHeight = intHeight;
            CalcArea();
        }

        public int IntBase { get => intBase; set => intBase = value; }
        public int IntHeight { get => intHeight; set => intHeight = value; }
        public void CalcArea()
        {
            dblArea = 0.0;
            dblArea = 0.5 * intBase * intHeight;
            Console.WriteLine("Area is :" + dblArea);
        }
    }
}
