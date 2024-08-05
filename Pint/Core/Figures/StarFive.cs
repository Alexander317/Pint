using System.Drawing.Drawing2D;

namespace Pint.Core.Figures
{
    internal class StarFive : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode)
        {
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            Point center = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
            int radius = Math.Min(Math.Abs(p2.X - p1.X) / 2, Math.Abs(p2.Y - p1.Y) / 2);

            Point[] starPoints = new Point[10];
            double angle = -Math.PI / 2;

            for (int i = 0; i < 10; i++)
            {
                double currentAngle = angle + i * Math.PI / 5;
                double currentRadius = (i % 2 == 0 ? radius : radius / 2.5);

                int x = center.X + (int)(currentRadius * Math.Cos(currentAngle));
                int y = center.Y + (int)(currentRadius * Math.Sin(currentAngle));
                starPoints[i] = new Point(x, y);
            }
            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = smoothingMode;
            graphics.DrawPolygon(pen, starPoints);
        }
    }
}