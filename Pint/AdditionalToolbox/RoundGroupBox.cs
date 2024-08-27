using System.Drawing.Drawing2D;

namespace Pint.AdditionalToolbox
{
    public class RoundGroupBox : GroupBox
    {
        public RoundGroupBox()
        {
            BackColor = Color.White;
            ForeColor = Color.Black;
            Size = new Size(350, 200);
        }

        #region Fields

        private int borderRadius = 12;
        private bool roundTopLeft = true;
        private bool roundTopRight = true;
        private bool roundBottomLeft = true;
        private bool roundBottomRight = true;

        #endregion

        #region Properties

        public int BorderRadius { get => borderRadius; set { borderRadius = value; Invalidate(); } }
        public bool RoundTopLeft { get => roundTopLeft; set { roundTopLeft = value; Invalidate(); } }
        public bool RoundTopRight { get => roundTopRight; set { roundTopRight = value; Invalidate(); } }
        public bool RoundBottomLeft { get => roundBottomLeft; set { roundBottomLeft = value; Invalidate(); } }
        public bool RoundBottomRight { get => roundBottomRight; set { roundBottomRight = value; Invalidate(); } }

        #endregion

        #region Functional

        private GraphicsPath GetGraphicsPath(RectangleF rect, float radius)
        {
            float diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            if (roundTopLeft)
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X + radius, rect.Y);

            if (roundTopRight)
                path.AddArc(rect.Width - diameter, rect.Y, diameter, diameter, 270, 90);
            else
                path.AddLine(rect.Width - radius, rect.Y, rect.Width, rect.Y);

            if (roundBottomRight)
                path.AddArc(rect.Width - diameter, rect.Height - diameter, diameter, diameter, 0, 90);
            else
                path.AddLine(rect.Width, rect.Height - radius, rect.Width, rect.Height);

            if (roundBottomLeft)
                path.AddArc(rect.X, rect.Height - diameter, diameter, diameter, 90, 90);
            else
                path.AddLine(rect.X + radius, rect.Height, rect.X, rect.Height);

            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Prevent the default GroupBox border from being drawn
            e.Graphics.Clear(BackColor);

            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetGraphicsPath(new RectangleF(0, 0, Width, Height), borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2))
                {
                    Region = new Region(path);
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else
            {
                Region = new Region(new RectangleF(0, 0, Width, Height));
            }

            // Draw the GroupBox text slightly lower
            using (SolidBrush brush = new SolidBrush(ForeColor))
            {
                SizeF textSize = e.Graphics.MeasureString(Text, Font);
                Rectangle textRect = new Rectangle(10, 2, (int)textSize.Width + 1, (int)textSize.Height + 1); // Adjusted Y position
                e.Graphics.FillRectangle(new SolidBrush(BackColor), textRect);
                e.Graphics.DrawString(Text, Font, brush, 10, 2); // Adjusted Y position
            }
        }

        #endregion
    }
}
