using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rectangle
    {
        private readonly float area;
        private readonly float perimeter;
        private readonly CortesianPoint vertex1;
        private readonly CortesianPoint vertex2;
        private readonly CortesianPoint vertex3;
        private readonly CortesianPoint vertex4;

        public Rectangle(CortesianPoint vertex1, CortesianPoint vertex3)
        {

            int rectangleBase = Math.Abs(vertex3.GetX() - vertex1.GetX());
            int rectangleHeight = Math.Abs(vertex3.GetY() - vertex1.GetY());

            area = (float)rectangleBase * rectangleHeight;
            perimeter = ((float)rectangleBase + rectangleHeight) * 2;

            this.vertex1 = vertex1;
            this.vertex3 = vertex3;

            ///CALCULO DE VERTICES 2 Y 4.
            int cortesianXVertex2 = vertex1.GetY() - rectangleHeight;
            int cortesianYVertex2 = vertex1.GetX();
            int cortesianXVertex4 = vertex3.GetY() - rectangleHeight;
            int cortesianYVertex4 = vertex3.GetX();


            vertex2 = new(cortesianXVertex2, cortesianYVertex2);
            vertex4 = new(cortesianXVertex4, cortesianYVertex4);

        }
        public float GetArea() { return area; }
        public float GetPerimeter() { return perimeter; }

    }
}
