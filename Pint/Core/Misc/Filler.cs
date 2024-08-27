using System.Configuration;
using System.Drawing.Imaging;

namespace Pint.Core.Misc
{
    internal class Filler : MainMisc
    {
        public override void UseMisc(Bitmap bitmap, Pen pen, Point lastPos)
        {
            if (ConfigurationManager.AppSettings["AgressiveFilling"] == "use")
                AgressiveFilling(bitmap, pen, lastPos);
            else
                SimpleFilling(bitmap, pen, lastPos);
        }

        private void SimpleFilling(Bitmap bitmap, Pen pen, Point lastPos)
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
                    }
                }
            }

            bitmap.UnlockBits(bitmapData);
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
