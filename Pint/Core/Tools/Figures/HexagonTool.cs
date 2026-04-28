using System.Configuration;
using System.Drawing.Drawing2D;

namespace Pint.Core.Tools.Figures
{
    internal class HexagonTool : ITool
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

            int dx = Math.Abs(p2.X - p1.X) >> 1;
            int dy = Math.Abs(p2.Y - p1.Y) >> 1;

            Point[] hexagonPoints = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = i * Math.PI / 3;
                hexagonPoints[i] = new Point(
                    centerX + (int)(dx * Math.Cos(angle)),
                    centerY + (int)(dy * Math.Sin(angle))
                );
            }

            using (Graphics graphics = Graphics.FromImage(bm))
            {
                graphics.SmoothingMode = ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed;
                graphics.DrawPolygon(pen, hexagonPoints);
            }
        }
    }
}
