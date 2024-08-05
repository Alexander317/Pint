using System.Drawing.Drawing2D;

namespace Pint.Core.Figures
{
    internal class RightTriangle : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode)
        {
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            Point topLeft = new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            Point bottomRight = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            Point bottomLeft = new Point(topLeft.X, bottomRight.Y);

            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = smoothingMode;
            graphics.DrawLine(pen, topLeft, bottomLeft); // Vertical side
            graphics.DrawLine(pen, bottomLeft, bottomRight); // Horizontal side
            graphics.DrawLine(pen, topLeft, bottomRight); // Hypotenuse
        }
    }
}
