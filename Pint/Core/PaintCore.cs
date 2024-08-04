using Pint.Core.Enums;
using Pint.Core.Figures;
using Pint.Core.Misc;
using Pint.Core.Pencils;


namespace Pint.Core
{
    public class PaintCore
    {

        #region FIELDS

        public int PosX { get; set; } = 0;
        public int PosY { get; set; } = 0;
        public MainEnum MainToolDefiner { get; set; }
        public MainFigure CurrentFigure { get; set; }
        public MainPencil CurrentPensil { get; set; }
        public MainMisc CurrentMisc { get; set; }
        private List<Bitmap> previousBitmaps = new();
        private List<Bitmap> futureBitmaps = new();
        public ArrayPoint arrayPoint = new(2);

        #endregion

        #region DRAWING

        public void Filter(Bitmap bitmap, Pen pen)
        {
            futureBitmaps.Clear();
            if (MainToolDefiner == MainEnum.Pensils) {
                CurrentPensil.UsePencil(bitmap, pen, this);
            } else if (MainToolDefiner == MainEnum.Figures) {
                CurrentFigure.UseFigure(bitmap, pen, arrayPoint);
            } else if (MainToolDefiner == MainEnum.Misc) {
                CurrentMisc.UseMisc(bitmap, pen, PosX, PosY);
            }
        }
        public Bitmap DrawOnCopiedBitmap(Bitmap bitmap, Pen pen)
        {
            arrayPoint.ResetOnlyLast();
            arrayPoint.SetPoint(PosX, PosY);
            CurrentFigure.UseFigure(bitmap, pen, arrayPoint);
            return bitmap;
        }
        public void ClearBM(Bitmap bitmap)
        {
            using Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
        }

        #endregion

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
