using System.Drawing.Drawing2D;
using Pint.Core;

namespace Pint.AdditionalToolbox
{
    public partial class LineControl : UserControl
    {
        #region Fields

        private float rotationAngle;
        private float lineWidth;
        private Color color;

        #endregion

        #region Params

        public float RotationAngle
        {
            get => rotationAngle;
            set
            {
                rotationAngle = value;
                Invalidate();
            }
        }
        public float LineWidth
        {
            get => lineWidth;
            set
            {
                lineWidth = value;
                Invalidate();
            }
        }
        public Color Color
        {
            get => color;
            set
            {
                color = value;
                Invalidate();
            }
        }

        #endregion

        public LineControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Получаем графику
            Graphics g = e.Graphics;

            // Определяем начальную и конечную точки линии
            Point startPoint = new Point(5, 10);
            Point endPoint = new Point(Width - 5, Height - 10);

            // Поворачиваем координаты точек на заданный угол
            Matrix rotationMatrix = new Matrix();
            rotationMatrix.RotateAt(rotationAngle, new PointF(Width / 2f, Height / 2f));
            g.Transform = rotationMatrix;

            // Рисуем линию
            using (Pen linePen = new(color, lineWidth))
            {
                PenHandler.MakePenRound(linePen);
                g.DrawLine(linePen, startPoint, endPoint);
            }
        }
    }
}
