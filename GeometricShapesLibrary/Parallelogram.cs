using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesLibrary {
    public class Parallelogram : Quadrilateral { //parallelogram inherts the quadrilateral class

        public int Area() {
            return Side1 * Side2;
        }

        public Parallelogram(int side1, int side2) : base(side1, side2, side1, side2) { //good practice to execute a constructor of the base class

        }
    }
}
