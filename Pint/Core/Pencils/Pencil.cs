using System.Drawing.Drawing2D;

namespace Pint.Core.Pencils
{
    internal class Pencil : MainPencil
    {
        public override void UsePencil(Bitmap bitmap, Pen pen, PaintCore paintCore, SmoothingMode smoothingMode)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = smoothingMode;
                Point startPoint = paintCore.arrayPoint.Points[0];
                Point endPoint = new(paintCore.PosX, paintCore.PosY);
                graphics.DrawLine(pen, startPoint, endPoint);
                paintCore.arrayPoint.ResetAll();
                paintCore.arrayPoint.SetPoint(paintCore.PosX, paintCore.PosY);
            }
        }
    }
}
