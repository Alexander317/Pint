using System.Configuration;
using System.Drawing.Drawing2D;

namespace Pint.Core.Tools.Figures
{
    internal class StarFiveTool : ITool
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

            float centerX = (p1.X + p2.X) * 0.5f;
            float centerY = (p1.Y + p2.Y) * 0.5f;
            float halfWidth = Math.Abs(p2.X - p1.X) * 0.5f;
            float halfHeight = Math.Abs(p2.Y - p1.Y) * 0.5f;

            float innerWidth = halfWidth * 0.382f;
            float innerHeight = halfHeight * 0.382f;

            PointF[] starPoints = new PointF[10];

            float angleStep = MathF.PI / 5f;
            float startAngle = -MathF.PI / 2f;

            for (int i = 0; i < 10; i++)
            {
                float angle = startAngle + i * angleStep;
                float currentWidth = (i % 2 == 0) ? halfWidth : innerWidth;
                float currentHeight = (i % 2 == 0) ? halfHeight : innerHeight;
                starPoints[i] = new PointF(
                    centerX + currentWidth * MathF.Cos(angle),
                    centerY + currentHeight * MathF.Sin(angle)
                );
            }

            using (Graphics graphics = Graphics.FromImage(bm))
            {
                graphics.SmoothingMode = ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed;
                graphics.DrawPolygon(pen, starPoints);
            }
        }
    }
}