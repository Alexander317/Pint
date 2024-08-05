﻿using System.Drawing.Drawing2D;

namespace Pint.Core.Pencils
{
    internal class Eraser : MainPencil
    {
        public override void UsePencil(Bitmap bitmap, Pen pen, PaintCore paintCore, SmoothingMode smoothingMode)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = smoothingMode;
                Pen EraserPen = new(Color.White, pen.Width);
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
