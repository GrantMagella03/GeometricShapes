using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    internal static class GeometricShapeFactory {
        public static ooQuad CreateInstance(int s1,int s2, int s3, int s4) {
            return new ooQuad(s1,s2,s3,s4);
        }
        public static ooQuad CreateInstance(int s1, int s2) {
            return new ooRect(s1, s2);
        }
        public static ooQuad CreateInstance(int s1) {
            return new ooSquare(s1);
        }
    }
}
