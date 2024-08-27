namespace Pint
{
    public partial class ScrollablePictureBox : UserControl
    {
        public ScrollablePictureBox()
        {
            InitializeComponent();
        }

        #region Functional

        public void SetImage(Image image) => pictureBox.Image = image;

        public Image GetImage() => pictureBox.Image;

        public void SetImageSize(Size size)
        {
            pictureBox.Size = size;
        }

        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }

        #endregion
    }
}
