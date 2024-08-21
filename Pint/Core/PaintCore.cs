using Pint.Core.Enums;
using Pint.Core.Figures;
using Pint.Core.Misc;
using Pint.Core.Pencils;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing;


namespace Pint.Core
{
    public class PaintCore
    {

        #region FIELDS

        public MainEnum MainToolDefiner { get; set; }
        public Point LastPos { get; set; }
        public MainFigure CurrentFigure { get; set; }
        public MainPencil CurrentPensil { get; set; }
        public MainMisc CurrentMisc { get; set; }
        private List<Bitmap> previousBitmaps = new();
        private List<Bitmap> futureBitmaps = new();
        public ArrayPoint arrayPoint = new(2);

        #endregion

        #region CREATING_CANVAS

        public Bitmap CreateBitmapBySize(Size size)
        {
            Bitmap bitmap = new(size.Width, size.Height);
            ClearBM(bitmap);
            return bitmap;
        }

        public void ClearBM(Bitmap bitmap)
        {
            using Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
        }

        #endregion

        #region DRAWING

        public void Filter(Bitmap bitmap, Pen pen)
        {
            futureBitmaps.Clear();
            if (MainToolDefiner == MainEnum.Pensils)
            {
                CurrentPensil.UsePencil(bitmap, pen, arrayPoint, 
                    ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed);
            }
            else if (MainToolDefiner == MainEnum.Figures)
            {
                CurrentFigure.UseFigure(bitmap, pen, arrayPoint,
                    ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed);
            }
            else if (MainToolDefiner == MainEnum.Misc)
            {
                CurrentMisc.UseMisc(bitmap, pen, LastPos);
            }
        }
        public Bitmap DrawOnCopiedBitmap(Bitmap bitmap, Pen pen)
        {
            arrayPoint.ResetOnlyLast();
            arrayPoint.SetPoint(LastPos);
            CurrentFigure.UseFigure(bitmap, pen, arrayPoint,
                ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed);
            return bitmap;
        }

        #endregion

        //RemakeMePlease
        #region PREVIOUS/FUTURE_BITMAPS

        public Bitmap ReturnToPreviousBitmap(Bitmap bitmap)
        {
            if (previousBitmaps.Count > 0)
            {
                futureBitmaps.Add(bitmap);
                bitmap = previousBitmaps[previousBitmaps.Count - 1];
                previousBitmaps.RemoveAt(previousBitmaps.Count - 1);
            }
            return bitmap;
        }
        public Bitmap ReturnToFutureBitmap(Bitmap bitmap)
        {
            if (futureBitmaps.Count > 0)
            {
                previousBitmaps.Add(bitmap);
                bitmap = futureBitmaps[futureBitmaps.Count - 1];
                futureBitmaps.RemoveAt(futureBitmaps.Count - 1);
            }
            return bitmap;
        }

        public void AddToPreviousBitmaps(Bitmap bitmap)
        {
            previousBitmaps.Add(bitmap);
        }
        #endregion
    }
}
