namespace Pint.Core.Figures
{
    internal class Line : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint)
        {
            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawLine(pen, arrayPoint.Points[0], arrayPoint.Points[1]);
        }
    }
}
