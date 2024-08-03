namespace Pint.Core
{
    public static class PenHandler
    {
        public static void MakePenRound(Pen pen)
        {
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        public static void SetPenParameters(Pen pen, float width, Color color)
        {
            pen.Color = color;
            pen.Width = width;
        }
    }
}
