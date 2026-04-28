using Pint.Core.Tools;

namespace Pint.Core
{
    public class PaintCore
    {
        #region Fields
        private ITool currentTool;
        private DrawingSettinngs settings = new();
        private List<Bitmap> previousBitmaps = new();
        private List<Bitmap> futureBitmaps = new();

        private List<Drawing> drawings = new();

        #endregion

        #region Properties

        public ITool CurrentTool { get => currentTool; set => currentTool = value;  }
        public DrawingSettinngs Settings { get => settings; set => settings = value; }

        #endregion

        #region Bitmap Formatting

        public Bitmap CreateBitmap(Size size)
        {
            Bitmap bitmap = new(size.Width, size.Height);
            ClearBitmap(bitmap);
            return bitmap;
        }

        public void ClearBitmap(Bitmap bitmap)
        {
            using Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
        }

        #endregion

        #region Undo/Redo
        


        #endregion

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
            previousBitmaps.Add((Bitmap)bitmap.Clone());
        }
        #endregion
    }
}
