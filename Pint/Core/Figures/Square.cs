namespace Pint.Core.Figures
{
    internal class Square : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint)
        {
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p2.X - p1.X);
            int height = Math.Abs(p2.Y - p1.Y);

            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.DrawRectangle(pen, x, y, width, height);
        }
    }
}
