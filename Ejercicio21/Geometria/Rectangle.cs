using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rectangle
    {
        private float area;
        private float perimeter;
        CortesianPoint vertex1;
        CortesianPoint vertex2;
        CortesianPoint vertex3;
        CortesianPoint vertex4;

        public Rectangle(CortesianPoint vertex1, CortesianPoint vertex3)
        {

            this.vertex1 = vertex1;
            this.vertex3 = vertex3;

            vertex1.GetX();
            vertex1.GetY();
        }



    }
}
