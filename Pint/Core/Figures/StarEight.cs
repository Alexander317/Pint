using System.Drawing.Drawing2D;

namespace Pint.Core.Figures
{
    internal class StarEight : MainFigure
    {
        public override void UseFigure(Bitmap bitmap, Pen pen, ArrayPoint arrayPoint, SmoothingMode smoothingMode)
        {
            // Получаем две диагональные точки, задающие ограничивающий прямоугольник
            Point p1 = arrayPoint.Points[0];
            Point p2 = arrayPoint.Points[1];

            // Вычисляем центр прямоугольника
            float centerX = (p1.X + p2.X) / 2f;
            float centerY = (p1.Y + p2.Y) / 2f;

            // Вычисляем половину ширины и высоты прямоугольника
            float halfWidth = Math.Abs(p2.X - p1.X) / 2f;
            float halfHeight = Math.Abs(p2.Y - p1.Y) / 2f;

            // Для формирования звезды используем два набора радиусов:
            // Внешние радиусы (для внешних вершин) равны половине ширины и высоты,
            // а внутренние – уменьшенные пропорционально (в данном случае в 2.5 раза),
            // чтобы сохранить внешний вид звезды.
            float innerWidth = halfWidth / 2.5f;
            float innerHeight = halfHeight / 2.5f;

            // 16 точек: 8 внешних и 8 внутренних
            PointF[] starPoints = new PointF[16];

            // Вычисляем координаты каждой из 16 точек звезды
            // Угол начинается с -90° (т. е. верхняя точка) и с шагом 22.5° (Math.PI/8) поворачиваемся вокруг центра.
            for (int i = 0; i < 16; i++)
            {
                double angle = -Math.PI / 2 + i * (Math.PI / 8);

                // Если индекс четный, то это внешняя точка – используем половину ширины/высоты
                // Если нечетный – внутренняя точка, используем уменьшенные радиусы
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

            // Создаем объект Graphics для рисования на Bitmap и устанавливаем режим сглаживания
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = smoothingMode;
                // Отрисовываем звезду, соединяя вычисленные точки
                graphics.DrawPolygon(pen, starPoints);
            }
        }

    }
}