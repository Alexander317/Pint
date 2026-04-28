using System.Drawing.Drawing2D;

namespace Pint.Core.Figures
{
    public abstract class MainFigure
    {
        public abstract void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode);
    }
}
