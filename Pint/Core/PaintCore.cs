using Pint.Core.Enums;
using Pint.Core.Figures;
using Pint.Core.Misc;
using Pint.Core.Pencils;


namespace Pint.Core
{
    public class PaintCore
    {
        public int PosX { get; set; } = 0;
        public int PosY { get; set; } = 0;
        public MainEnum MainToolDefiner { get; set; }
        public MainFigure CurrentFigure { get; set; }
        public MainPencil CurrentPensil { get; set; }
        public MainMisc CurrentMisc { get; set; }
        List<Bitmap> previousBitmaps = [];
        List<Bitmap> futureBitmaps = [];
        public ArrayPoint arrayPoint = new(2);


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
        public void ClearBitmap(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            graphics.Dispose();
        }
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
        /*public Bitmap ReturnToPreviousBitmap(ref Bitmap currentBitmap)
        {
            if (previousBitmaps.Count > 0)
            {
                // Store the current bitmap in futureBitmaps
                futureBitmaps.Add(currentBitmap);

                // Retrieve the last bitmap from previousBitmaps
                Bitmap previousBitmap = previousBitmaps[previousBitmaps.Count - 1];
                previousBitmaps.RemoveAt(previousBitmaps.Count - 1);

                // Dispose of the current bitmap
                currentBitmap.Dispose();

                // Assign the previous bitmap as the current bitmap
                currentBitmap = previousBitmap;
            }

            return currentBitmap;
        }

        public Bitmap ReturnToFutureBitmap(ref Bitmap currentBitmap)
        {
            if (futureBitmaps.Count > 0)
            {
                // Store the current bitmap in previousBitmaps
                previousBitmaps.Add(currentBitmap);

                // Retrieve the last bitmap from futureBitmaps
                Bitmap futureBitmap = futureBitmaps[futureBitmaps.Count - 1];
                futureBitmaps.RemoveAt(futureBitmaps.Count - 1);

                // Dispose of the current bitmap
                currentBitmap.Dispose();

                // Assign the future bitmap as the current bitmap
                currentBitmap = futureBitmap;
            }

            return currentBitmap;
        }*/
        public void AddToPreviousBitmaps(Bitmap bitmap)
        {
            previousBitmaps.Add(new Bitmap(bitmap));
        }
        public void ClearBM(Bitmap bitmap)
        {
            using Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
        }
    }
}
