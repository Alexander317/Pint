using System.Drawing.Drawing2D;

namespace Pint.Core.Pencils
{
    public abstract class MainPencil
    {
        public abstract void UsePencil(Bitmap bitmap, Pen pen, PaintCore paintCore, SmoothingMode smoothingMode);
    }
}
