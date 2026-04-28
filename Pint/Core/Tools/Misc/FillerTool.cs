using System.Configuration;
using System.Drawing.Imaging;

namespace Pint.Core.Tools.Misc
{
    internal class FillerTool : ITool
    {
        public bool RequiresPreview { get; } = false;

        public void OnMouseDown(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            
        }

        public void OnMouseMove(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            
        }

        public void OnMouseUp(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            using (Pen pen = new Pen(settings.CurrentColor, settings.PenWidth))
            {
                PenHandler.MakePenRound(pen);
                if (ConfigurationManager.AppSettings["AgressiveFilling"] == "use")
                    AgressiveFilling(bm, pen, new Point(e.X, e.Y));
                else
                    SimpleFilling(bm, pen, new Point(e.X, e.Y));
            }
        }

        private void SimpleFilling(Bitmap bitmap, Pen pen, Point lastPos)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            int targetArgb = bitmap.GetPixel(lastPos.X, lastPos.Y).ToArgb();
            int fillArgb = pen.Color.ToArgb();

            if (targetArgb == fillArgb) return;

            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb
            );

            unsafe
            {
                int* ptr = (int*)data.Scan0;
                int[] stack = new int[width * height];
                int count = 0;

                int startIndex = lastPos.Y * width + lastPos.X;
                ptr[startIndex] = fillArgb;
                stack[count++] = startIndex;

                while (count > 0)
                {
                    int index = stack[--count];
                    int x = index % width;
                    int y = index / width;

                    if (x > 0 && ptr[index - 1] == targetArgb)
                    {
                        ptr[index - 1] = fillArgb;
                        stack[count++] = index - 1;
                    }

                    if (x < width - 1 && ptr[index + 1] == targetArgb)
                    {
                        ptr[index + 1] = fillArgb;
                        stack[count++] = index + 1;
                    }

                    if (y > 0 && ptr[index - width] == targetArgb)
                    {
                        ptr[index - width] = fillArgb;
                        stack[count++] = index - width;
                    }

                    if (y < height - 1 && ptr[index + width] == targetArgb)
                    {
                        ptr[index + width] = fillArgb;
                        stack[count++] = index + width;
                    }
                }
            }

            bitmap.UnlockBits(data);
        }

        private void AgressiveFilling(Bitmap bitmap, Pen pen, Point lastPos)
        {
            Color oldColor = bitmap.GetPixel(lastPos.X, lastPos.Y);

            if (oldColor.ToArgb() == pen.Color.ToArgb())
                return;

            int width = bitmap.Width;
            int height = bitmap.Height;
            int penArgb = pen.Color.ToArgb();

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(lastPos.X, lastPos.Y));

            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
            int bytesPerPixel = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;

            unsafe
            {
                byte* startPtr = (byte*)bitmapData.Scan0;

                while (pixels.Count > 0)
                {
                    Point point = pixels.Pop();
                    int x = point.X;
                    int y = point.Y;

                    if (x < 0 || y < 0 || x >= width || y >= height)
                        continue;

                    byte* currentPixel = startPtr + y * bitmapData.Stride + x * bytesPerPixel;

                    if (Color.FromArgb(currentPixel[2], currentPixel[1], currentPixel[0]).ToArgb() == oldColor.ToArgb())
                    {
                        currentPixel[0] = (byte)(penArgb & 0xFF);
                        currentPixel[1] = (byte)((penArgb >> 8) & 0xFF);
                        currentPixel[2] = (byte)((penArgb >> 16) & 0xFF);

                        if (x - 1 >= 0)
                            pixels.Push(new Point(x - 1, y));
                        if (x + 1 < width)
                            pixels.Push(new Point(x + 1, y));
                        if (y - 1 >= 0)
                            pixels.Push(new Point(x, y - 1));
                        if (y + 1 < height)
                            pixels.Push(new Point(x, y + 1));
                    }
                    else
                    {
                        currentPixel[0] = (byte)(penArgb & 0xFF);
                        currentPixel[1] = (byte)((penArgb >> 8) & 0xFF);
                        currentPixel[2] = (byte)((penArgb >> 16) & 0xFF);

                        for (int dx = -1; dx <= 1; dx++)
                        {
                            for (int dy = -1; dy <= 1; dy++)
                            {
                                if ((dx != 0 || dy != 0) && x + dx >= 0 && x + dx < width && y + dy >= 0 && y + dy < height)
                                {
                                    byte* neighborPixel = startPtr + (y + dy) * bitmapData.Stride + (x + dx) * bytesPerPixel;

                                    if (Color.FromArgb(neighborPixel[2], neighborPixel[1], neighborPixel[0]).ToArgb() != oldColor.ToArgb())
                                    {
                                        neighborPixel[0] = (byte)(penArgb & 0xFF);
                                        neighborPixel[1] = (byte)((penArgb >> 8) & 0xFF);
                                        neighborPixel[2] = (byte)((penArgb >> 16) & 0xFF);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            bitmap.UnlockBits(bitmapData);
        }
    }
}
