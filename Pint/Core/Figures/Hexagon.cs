using System.Drawing.Drawing2D;

namespace Pint.Core.Figures
{
    internal class Hexagon : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode)
        {
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            int centerX = (p1.X + p2.X) >> 1;
            int centerY = (p1.Y + p2.Y) >> 1;

            int dx = Math.Abs(p2.X - p1.X) >> 1;
            int dy = Math.Abs(p2.Y - p1.Y) >> 1;

            Point[] hexagonPoints = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = i * Math.PI / 3;
                hexagonPoints[i] = new Point(
                    centerX + (int)(dx * Math.Cos(angle)),
                    centerY + (int)(dy * Math.Sin(angle))
                );
            }

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = smoothingMode;
                graphics.DrawPolygon(pen, hexagonPoints);
            }
        }
    }
}
