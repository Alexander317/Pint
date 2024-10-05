namespace Pint
{
    public partial class ScrollablePictureBox : UserControl
    {
        public ScrollablePictureBox()
        {
            InitializeComponent();
        }

        #region Functional

        public void SetImage(Image image)
        {
            SetPBSize(image.Size);
            pictureBox.Image = image;
        }

        public Image GetImage()
        {
            return pictureBox.Image;
        }

        public void SetPBSize(Size size)
        {
            pictureBox.Size = size;
        }
        public void SetPBSize(int Width, int Height)
        {
            pictureBox.Size = new Size(Width, Height);
        }

        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }

        #endregion
    }
}
