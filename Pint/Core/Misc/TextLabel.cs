namespace Pint.Core.Misc
{
    internal class TextLabel : MainMisc
    {
        public override void UseMisc(Bitmap bitmap, Pen pen, int posX, int posY)
        {
            Label label = new()
            {
                Location = new Point(posX, posY),
                Text = "test",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                AutoSize = true
            };
            label.Show();
        }
    }
}
