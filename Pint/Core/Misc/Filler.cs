using System.Drawing.Imaging;

namespace Pint.Core.Misc
{
    internal class Filler : MainMisc
    {
        public override void UseMisc(Bitmap bitmap, Pen pen, int posX, int posY)
        {
            Color oldColor = bitmap.GetPixel(posX, posY);

            if (oldColor.ToArgb() == pen.Color.ToArgb())
                return;

            int width = bitmap.Width;
            int height = bitmap.Height;
            int penArgb = pen.Color.ToArgb();

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(posX, posY));

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

                    if (Color.FromArgb(currentPixel[2], currentPixel[1], currentPixel[0]).ToArgb() != oldColor.ToArgb())
                        continue;

                    currentPixel[0] = (byte)(penArgb & 0xFF);
                    currentPixel[1] = (byte)((penArgb >> 8) & 0xFF);
                    currentPixel[2] = (byte)((penArgb >> 16) & 0xFF);

                    // Push adjacent pixels
                    if (x - 1 >= 0)
                        pixels.Push(new Point(x - 1, y));
                    if (x + 1 < width)
                        pixels.Push(new Point(x + 1, y));
                    if (y - 1 >= 0)
                        pixels.Push(new Point(x, y - 1));
                    if (y + 1 < height)
                        pixels.Push(new Point(x, y + 1));
                }
            }

            bitmap.UnlockBits(bitmapData);
        }

    }
}
