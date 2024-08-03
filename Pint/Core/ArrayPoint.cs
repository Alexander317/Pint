namespace Pint.Core
{
    public class ArrayPoint
    {
        public int Index {  get; private set; }
        public Point[] Points { get; private set; }
        public ArrayPoint(int size)
        {
            if (size <= 0)
                size = 2;
            Points = new Point[size];
        }
        public void SetPoint(int x, int y)
        {
            if (Index >= Points.Length)
                Index = 0;
            Points[Index] = new Point(x, y);
            Index++;
        }
        public void ResetAll() => Index = 0;
        public void ResetOnlyLast() => Index = 1;
        public void FlipPoints()
        {
            if (Index < 2)
                return;
            Point point = Points[1];
            Points[1] = Points[0];
            Points[0] = point;
        }
    }
}
