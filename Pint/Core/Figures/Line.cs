namespace Pint.Core.Figures
{
    internal class Line : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint)
        {
            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.DrawLine(pen, arrayPoint.Points[0], arrayPoint.Points[1]);
        }
    }
}
