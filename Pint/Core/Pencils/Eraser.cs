using System.Drawing.Drawing2D;

namespace Pint.Core.Pencils
{
    internal class Eraser : MainPencil
    {
        public override void UsePencil(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = smoothingMode;
                Pen EraserPen = new(Color.White, pen.Width);
                PenHandler.MakePenRound(EraserPen);
                graphics.DrawLine(EraserPen, arrayPoint.Points[0], arrayPoint.Points[1]);
                arrayPoint.ResetAll();
                arrayPoint.SetPoint(arrayPoint.Points[1]);
            }
        }
    }
}
