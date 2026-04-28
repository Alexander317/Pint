using System.Configuration;
using System.Drawing.Drawing2D;

namespace Pint.Core.Tools.Figures
{
    internal class RhombusTool : ITool
    {
        public bool RequiresPreview { get; } = true;
        public void OnMouseDown(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            ap.SetPoint(e.X, e.Y);
        }

        public void OnMouseMove(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            using (Pen pen = new Pen(settings.CurrentColor, settings.PenWidth))
            {
                PenHandler.MakePenRound(pen);
                Draw(e, bm, pen, ap);
            }
        }

        public void OnMouseUp(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            using (Pen pen = new Pen(settings.CurrentColor, settings.PenWidth))
            {
                PenHandler.MakePenRound(pen);
                Draw(e, bm, pen, ap);
            }
        }
        private void Draw(MouseEventArgs e, Bitmap bm, Pen pen, ArrayPoint ap)
        {
            ap.ResetOnlyLast();
            ap.SetPoint(e.X, e.Y);

            Point p1 = ap.Points[0];
            Point p2 = ap.Points[1];

            int centerX = (p1.X + p2.X) >> 1;
            int centerY = (p1.Y + p2.Y) >> 1;

            int dx = (p2.X - p1.X) >> 1;
            int dy = (p2.Y - p1.Y) >> 1;

            Point[] diamondPoints =
            {
                new Point(centerX, centerY - dy),
                new Point(centerX + dx, centerY),
                new Point(centerX, centerY + dy),
                new Point(centerX - dx, centerY)
            };

            using (Graphics graphics = Graphics.FromImage(bm))
            {
                graphics.SmoothingMode = ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed;
                graphics.DrawPolygon(pen, diamondPoints);
            }
        }
    }
}
