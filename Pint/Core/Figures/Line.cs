using System.Drawing.Drawing2D;

namespace Pint.Core.Figures
{
    internal class Line : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode)
        {
            using Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = smoothingMode;
            graphics.DrawLine(pen, arrayPoint.Points[0], arrayPoint.Points[1]);
        }
    }
}
