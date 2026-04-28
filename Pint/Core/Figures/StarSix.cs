using System.Drawing.Drawing2D;

namespace Pint.Core.Figures
{
    internal class StarSix : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode)
        {
            // Получаем две диагональные точки ограничивающего прямоугольника
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            // Вычисляем центр и полуширину/полувысоту прямоугольника
            float centerX = (p1.X + p2.X) / 2f;
            float centerY = (p1.Y + p2.Y) / 2f;
            float halfWidth = Math.Abs(p2.X - p1.X) / 2f;
            float halfHeight = Math.Abs(p2.Y - p1.Y) / 2f;

            // Внешние "радиусы" – это половина ширины и высоты.
            // Для внутренних точек выбран коэффициент 0.5, позволяющий получить гармоничную форму.
            float innerFactor = 0.5f;
            float innerWidth = halfWidth * innerFactor;
            float innerHeight = halfHeight * innerFactor;

            // Всего вершин: 12 (6 внешних + 6 внутренних)
            PointF[] starPoints = new PointF[12];

            // Шаг по углу равен 360/12 = 30° (π/6 радиан)
            for (int i = 0; i < 12; i++)
            {
                // Начинаем с -90° (чтобы верхняя точка была вверху)
                double angle = -Math.PI / 2 + i * (Math.PI / 6);
                bool isOuter = (i % 2 == 0); // внешние вершины для чётных индексов
                float currentWidth = isOuter ? halfWidth : innerWidth;
                float currentHeight = isOuter ? halfHeight : innerHeight;

                // Вычисляем координаты каждой точки с учётом центра и выбранного "радиуса" по осям
                starPoints[i] = new PointF(
                    centerX + (float)(currentWidth * Math.Cos(angle)),
                    centerY + (float)(currentHeight * Math.Sin(angle))
                );
            }

            // Создаем Graphics для рисования и устанавливаем режим сглаживания
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = smoothingMode;
                graphics.DrawPolygon(pen, starPoints);
            }
        }
    }
}