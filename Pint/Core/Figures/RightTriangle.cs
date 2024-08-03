namespace Pint.Core.Figures
{
    internal class RightTriangle : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint)
        {
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawLine(pen, p1, p2);
            graphics.DrawLine(pen, p1.X, p1.Y, p1.X, p2.Y);
            graphics.DrawLine(pen, p1.X, p2.Y, p2.X, p2.Y);
        }
    }
}
