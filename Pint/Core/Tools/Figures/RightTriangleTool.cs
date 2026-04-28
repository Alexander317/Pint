using System.Configuration;
using System.Drawing.Drawing2D;

namespace Pint.Core.Tools.Figures
{
    internal class RightTriangleTool : ITool
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

            Point topLeft = new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            Point bottomRight = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            Point bottomLeft = new Point(topLeft.X, bottomRight.Y);

            using Graphics graphics = Graphics.FromImage(bm);
            graphics.SmoothingMode = ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed; 
            graphics.DrawLine(pen, topLeft, bottomLeft); // Vertical side
            graphics.DrawLine(pen, bottomLeft, bottomRight); // Horizontal side
            graphics.DrawLine(pen, topLeft, bottomRight); // Hypotenuse
        }
    }
}
