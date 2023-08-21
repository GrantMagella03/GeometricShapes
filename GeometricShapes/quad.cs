using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class quad
    {
        public int SideN { get; set; }
        public int SideS { get; set; }
        public int SideE { get; set; }
        public int SideW { get; set; }

        public quad(int N,int E, int S, int W)
        {
            SideN = N; SideS = S; SideE = E; SideW = W;
        }

        public int perimeter()
        {
            return SideN+SideE+SideS+SideW;
        }
    }
}
