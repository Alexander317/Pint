using System.Drawing.Drawing2D;

namespace Pint.Core.Figures
{
    internal class StarFive : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode)
        {
            // Получаем две диагональные точки ограничивающего прямоугольника
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            // Вычисляем центр и полуширину/полувысоту (используем умножение на 0.5f вместо деления)
            float centerX = (p1.X + p2.X) * 0.5f;
            float centerY = (p1.Y + p2.Y) * 0.5f;
            float halfWidth = Math.Abs(p2.X - p1.X) * 0.5f;
            float halfHeight = Math.Abs(p2.Y - p1.Y) * 0.5f;

            // Определяем внутренние радиусы как долю от внешних (коэффициент ~0.382 для пятиконечной звезды)
            float innerWidth = halfWidth * 0.382f;
            float innerHeight = halfHeight * 0.382f;

            // Всего вершин: 10 (чередуются внешние и внутренние)
            PointF[] starPoints = new PointF[10];

            // Предварительно вычисляем шаг по углу и стартовый угол (-90°)
            float angleStep = MathF.PI / 5f;
            float startAngle = -MathF.PI / 2f;

            for (int i = 0; i < 10; i++)
            {
                float angle = startAngle + i * angleStep;
                // Четные индексы – внешние вершины, нечетные – внутренние
                float currentWidth = (i % 2 == 0) ? halfWidth : innerWidth;
                float currentHeight = (i % 2 == 0) ? halfHeight : innerHeight;
                starPoints[i] = new PointF(
                    centerX + currentWidth * MathF.Cos(angle),
                    centerY + currentHeight * MathF.Sin(angle)
                );
            }

            // Отрисовка звезды с заданным режимом сглаживания
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = smoothingMode;
                graphics.DrawPolygon(pen, starPoints);
            }
        }
    }
}