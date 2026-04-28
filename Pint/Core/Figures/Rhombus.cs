using System.Drawing.Drawing2D;

namespace Pint.Core.Figures
{
    internal class Rhombus : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode)
        {
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            int centerX = (p1.X + p2.X) >> 1;
            int centerY = (p1.Y + p2.Y) >> 1;

            int dx = (p2.X - p1.X) >> 1;
            int dy = (p2.Y - p1.Y) >> 1;

            Point[] diamondPoints =
            {
                new Point(centerX, centerY - dy),
                new Point(centerX + dx, centerY),
                new Point(centerX, centerY + dy),
                new Point(centerX - dx, centerY)
            };

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = smoothingMode;
                graphics.DrawPolygon(pen, diamondPoints);
            }
        }
    }
}
