using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    internal class ooRect : ooQuad {
        public ooRect(int L, int W): base(L,W,L,W) {

        }
        public int area() {
            return Side1 * Side2;
        }
    }
}
