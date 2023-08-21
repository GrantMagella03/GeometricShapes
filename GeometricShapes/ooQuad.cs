using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class ooQuad
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public ooQuad(int s1, int s2, int s3, int s4)
        {
            Side1 = s1; Side2 = s2; Side3 = s3; Side4 = s4;
        }

        public int perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }
    }
}
