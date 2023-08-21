using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Rect
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public Rect(int L,int W)
        {
            Length = L;Width = W;
        }
        public int perimeter()
        {
            return (Length + Width) * 2;
        }
        public int area()
        {
            return (Length * Width);
        }
    }
}
