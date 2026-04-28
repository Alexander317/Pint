using System.Configuration;
using System.Drawing.Drawing2D;

namespace Pint.Core.Tools.Pencils
{
    internal class PencilTool : ITool
    {
        public bool RequiresPreview { get; } = false;
        public void OnMouseDown(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            ap.SetPoint(e.X, e.Y);
        }

        public void OnMouseMove(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            ap.SetPoint(e.X, e.Y);
            Draw(e, bm, settings, ap);
        }

        public void OnMouseUp(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            ap.ResetAll();
        }

        private void Draw(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            using (Graphics graphics = Graphics.FromImage(bm))
            {
                using (Pen pen = new Pen(settings.CurrentColor, settings.PenWidth))
                {
                    PenHandler.MakePenRound(pen);
                    Point p1 = ap.Points[0];
                    Point p2 = ap.Points[1];

                    graphics.SmoothingMode = ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed;
                    graphics.DrawLine(pen, p1, p2);
                    ap.ResetAll();
                    ap.SetPoint(p2);
                }
            }
        }
    }
}
