using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Square
    {
        public int side1 { get; set; }
        public Square(int s1)
        {
            side1 = s1;
        }
        public int perimeter()
        {
            return side1 * 4;
        }
        public int area()
        {
            return side1 * 2;
        }
    }
}
