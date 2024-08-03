namespace Pint.Core.Pencils
{
    internal class Eraser : MainPencil
    {
        public override void UsePencil(Bitmap bitmap, Pen pen, PaintCore paintCore)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Pen EraserPen = new Pen(Color.White, pen.Width * 3);
                PenHandler.MakePenRound(EraserPen);
                Point startPoint = paintCore.arrayPoint.Points[0];
                Point endPoint = new(paintCore.PosX, paintCore.PosY);
                graphics.DrawLine(EraserPen, startPoint, endPoint);
                paintCore.arrayPoint.ResetAll();
                paintCore.arrayPoint.SetPoint(paintCore.PosX, paintCore.PosY);
            }
        }
    }
}
