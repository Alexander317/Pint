using System.Configuration;
using System.Drawing.Drawing2D;

namespace Pint.Core.Tools.Figures
{
    internal class StarEightTool : ITool
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

            float centerX = (p1.X + p2.X) / 2f;
            float centerY = (p1.Y + p2.Y) / 2f;

            float halfWidth = Math.Abs(p2.X - p1.X) / 2f;
            float halfHeight = Math.Abs(p2.Y - p1.Y) / 2f;

            float innerWidth = halfWidth / 2.5f;
            float innerHeight = halfHeight / 2.5f;

            PointF[] starPoints = new PointF[16];

            for (int i = 0; i < 16; i++)
            {
                double angle = -Math.PI / 2 + i * (Math.PI / 8);

                if (i % 2 == 0)
                {
                    starPoints[i] = new PointF(
                        centerX + (float)(halfWidth * Math.Cos(angle)),
                        centerY + (float)(halfHeight * Math.Sin(angle))
                    );
                }
                else
                {
                    starPoints[i] = new PointF(
                        centerX + (float)(innerWidth * Math.Cos(angle)),
                        centerY + (float)(innerHeight * Math.Sin(angle))
                    );
                }
            }

            using (Graphics graphics = Graphics.FromImage(bm))
            {
                graphics.SmoothingMode = ConfigurationManager.AppSettings["Anti-Aliasing"] == "use" ? SmoothingMode.AntiAlias : SmoothingMode.HighSpeed;
                graphics.DrawPolygon(pen, starPoints);
            }
        }
    }
}