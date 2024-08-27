namespace Pint.Core
{
    public class ArrayPoint
    {

        #region Fields

        private int index;
        private Point[] points;

        #endregion

        #region Properties

        public int Index {  get => index; }
        public Point[] Points { get => points; }

        #endregion

        public ArrayPoint(int size)
        {
            if (size <= 0)
                size = 2;
            points = new Point[size];
        }

        #region Functional

        public void SetPoint(int x, int y)
        {
            if (Index >= Points.Length)
                index = 0;
            points[Index] = new Point(x, y);
            index++;
        }
        public void SetPoint(Point lastPoint)
        {
            if (index >= points.Length)
                index = 0;
            points[index] = lastPoint;
            index++;
        }
        public void ResetAll() => index = 0;
        public void ResetOnlyLast() => index = 1;
        public void FlipPoints()
        {
            if (index < 2)
                return;
            var point = points[1];
            points[1] = points[0];
            points[0] = point;
        }

        #endregion
    }
}
