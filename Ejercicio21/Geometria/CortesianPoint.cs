namespace Geometria
{
    public class CortesianPoint
    {
        private readonly int x;
        private readonly int y;

        public CortesianPoint(int x, int y)
        {
            this.x = x; 
            this.y = y;
        }
        public int GetX() { return x; }
        public int GetY() { return y; }

    }
}