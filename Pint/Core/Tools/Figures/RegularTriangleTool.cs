using System.Configuration;
using System.Drawing.Drawing2D;

namespace Pint.Core.Tools.Figures
{
    internal class RegularTriangleTool : ITool
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

            Point topVertex = new Point((Math.Min(p1.X, p2.X) + Math.Max(p1.X, p2.X)) / 2, Math.Min(p1.Y, p2.Y));
            Point leftVertex = new Point(Math.Min(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            Point rightVertex = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));

            using Graphics graphics = Graphics.FromImage(bm);
            graphics.SmoothingMode = ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed;
            graphics.DrawLine(pen, topVertex, leftVertex);
            graphics.DrawLine(pen, leftVertex, rightVertex);
            graphics.DrawLine(pen, rightVertex, topVertex);
        }
    }
}
