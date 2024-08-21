namespace Pint.Core.Misc
{
    internal class TextLabel : MainMisc
    {
        public override void UseMisc(Bitmap bitmap, Pen pen, Point lastPos)
        {
            Label label = new()
            {
                Location = lastPos,
                Text = "test",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                AutoSize = true
            };
            label.Show();
        }
    }
}
