namespace Pint.Core.Figures
{
    internal class RegularTriangle : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint)
        {
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            Point topVertex = new Point((Math.Min(p1.X, p2.X) + Math.Max(p1.X, p2.X)) / 2, Math.Min(p1.Y, p2.Y));
            Point leftVertex = new Point(Math.Min(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            Point rightVertex = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));

            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.DrawLine(pen, topVertex, leftVertex);
            graphics.DrawLine(pen, leftVertex, rightVertex);
            graphics.DrawLine(pen, rightVertex, topVertex);
        }
    }
}
