using Pint.Core.Enums;
using Pint.Core.Figures;
using Pint.Core.Misc;
using Pint.Core.Pencils;
using System.Configuration;
using System.Drawing.Drawing2D;


namespace Pint.Core
{
    public class PaintCore
    {
        #region Fields

        private MainEnum mainToolDefiner;
        private Point lastPos;
        private MainFigure currentFigure;
        private MainPencil currentPencil;
        private MainMisc currentMisc;
        private List<Bitmap> previousBitmaps = new();
        private List<Bitmap> futureBitmaps = new();
        private ArrayPoint arrayPoint = new(2);
        private ArrayPoint buttonAP = new(2);
        private Bitmap buttonBitmap;

        #endregion

        #region Properties

        public MainEnum MainToolDefiner {  get => mainToolDefiner; set => mainToolDefiner = value;  }
        public Point LastPos { get => lastPos; set => lastPos = value; }
        public MainFigure CurrentFigure { get => currentFigure; set => currentFigure = value; }
        public MainPencil CurrentPensil { get => currentPencil; set => currentPencil = value; }
        public MainMisc CurrentMisc { get => currentMisc; set => currentMisc = value; }
        public ArrayPoint ArrayPoint { get => arrayPoint; }

        #endregion

        #region Bitmap Formatting

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

        #region Main Drawing

        public void Filter(Bitmap bitmap, Pen pen)
        {
            futureBitmaps.Clear();
            if (mainToolDefiner == MainEnum.Pensils)
            {
                currentPencil.UsePencil(bitmap, pen, arrayPoint, 
                    ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed);
            }
            else if (mainToolDefiner == MainEnum.Figures)
            {
                currentFigure.UseFigure(bitmap, pen, arrayPoint,
                    ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed);
            }
            else if (mainToolDefiner == MainEnum.Misc)
            {
                currentMisc.UseMisc(bitmap, pen, lastPos);
            }
        }
        public Bitmap DrawOnCopiedBitmap(Bitmap bitmap, Pen pen)
        {
            arrayPoint.ResetOnlyLast();
            arrayPoint.SetPoint(lastPos);
            currentFigure.UseFigure(bitmap, pen, arrayPoint,
                ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed);
            return bitmap;
        }

        #endregion

        #region Button Drawing

        public void SetArrayPoint()
        {
            buttonAP.SetPoint(18, 18);
            buttonAP.SetPoint(44, 44);
        }

        public void DrawOnButton(Button button)
        {
            buttonBitmap = new Bitmap(64, 64);
            using (Graphics g = Graphics.FromImage(buttonBitmap))
            {
                currentFigure = EnumsHandler.getFigure((FiguresEnum)button.Tag); 
                currentFigure.UseFigure(buttonBitmap, new Pen(ConfigurationManager.AppSettings["UIMode"] == "light" ? Color.Black : Color.White, 2), buttonAP, SmoothingMode.AntiAlias);
                button.Image = buttonBitmap;
            }
        }

        #endregion

        //RemakeMePlease
        #region Prev/Fut Bitmaps

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
