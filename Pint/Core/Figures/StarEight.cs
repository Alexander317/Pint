namespace Pint.Core.Figures
{
    internal class StarEight : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint)
        {
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            int centerX = (p1.X + p2.X) / 2;
            int centerY = (p1.Y + p2.Y) / 2;

            int radius = Math.Min(Math.Abs(p2.X - p1.X) / 2, Math.Abs(p2.Y - p1.Y) / 2);
            double innerRadius = radius / 2.5;

            double[] angles = new double[16];
            for (int i = 0; i < 16; i++)
            {
                angles[i] = -Math.PI / 2 + i * Math.PI / 8;
            }

            PointF[] starPoints = new PointF[16];
            for (int i = 0; i < 16; i++)
            {
                double currentRadius = (i % 2 == 0) ? radius : innerRadius;
                starPoints[i] = new PointF(
                    centerX + (float)(currentRadius * Math.Cos(angles[i])),
                    centerY + (float)(currentRadius * Math.Sin(angles[i]))
                );
            }

            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.DrawPolygon(pen, starPoints);
        }

    }
}