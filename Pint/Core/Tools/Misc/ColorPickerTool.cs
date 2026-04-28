namespace Pint.Core.Tools.Misc
{
    public class ColorPickerTool : ITool
    {
        public bool RequiresPreview { get; } = false;
        public void OnMouseDown(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            PickColor(e, bm, settings, ap);
        }

        public void OnMouseMove(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            PickColor(e, bm, settings, ap);
        }

        public void OnMouseUp(MouseEventArgs e, Bitmap bm, DrawingSettinngs settings, ArrayPoint ap)
        {
            PickColor(e, bm, settings, ap);
        }
        private void PickColor(MouseEventArgs e, Bitmap bitmap, DrawingSettinngs settings, ArrayPoint ap)
        {
            settings.CurrentColor = bitmap.GetPixel(e.X, e.Y);
        }
    }
}
