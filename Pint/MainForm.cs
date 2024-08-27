using Pint.Core.Enums;
using Pint.Core;
using Pint.Core.Pencils;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using Pint.Core.Misc;
using Pint.Properties;

namespace Pint
{
    public delegate void OnThemeChanged();
    public partial class MainForm : Form
    {
        #region Fields

        private PaintCore paintCore = new();
        private Pen pen = new(Color.Black, 1);
        private Bitmap MainBitmap;
        private Bitmap CopyBitmap;
        private bool mouseDown = false;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            InitializeButtons();

            SetButtonTags();
            paintCore.MainToolDefiner = MainEnum.Pensils;
            paintCore.CurrentPensil = new Pencil();

            scrollablePictureBox.GetPictureBox().MouseDown += MainImage_MouseDown;
            scrollablePictureBox.GetPictureBox().MouseMove += MainImage_MouseMove;
            scrollablePictureBox.GetPictureBox().MouseUp += MainImage_MouseUp;
            scrollablePictureBox.GetPictureBox().MouseClick += MainImage_Click;

            UpdateCurrentColors(pen.Color);
            ButtonHandler.Select(Pencil_Btn);
            SetUITheme();
            PenTrackBar_Scroll(new object(), new EventArgs());
            PenHandler.MakePenRound(pen);
        }

        #region Main Image Handlers

        private void MainImage_MouseDown(object sender, MouseEventArgs e)
        {
            paintCore.ArrayPoint.SetPoint(e.X, e.Y);
            mouseDown = true;
            if (paintCore.MainToolDefiner == MainEnum.Figures)
                DrawingTimer.Enabled = true;
        }
        private void MainImage_MouseMove(object sender, MouseEventArgs e)
        {
            CoordinatesLabel.Text = $"{e.X}, {e.Y}пкс";
            paintCore.LastPos = new Point(e.X, e.Y);
            if (!mouseDown)
                return;


            if (paintCore.MainToolDefiner == MainEnum.Pensils)
            {
                paintCore.ArrayPoint.SetPoint(paintCore.LastPos);
                paintCore.Filter(MainBitmap, pen);
                scrollablePictureBox.SetImage(MainBitmap);
            }
        }
        private void MainImage_MouseUp(object sender, MouseEventArgs e)
        {
            DrawingTimer.Enabled = false;
            mouseDown = false;
            CopyBitmap?.Dispose();
            paintCore.Filter(MainBitmap, pen);
            scrollablePictureBox.SetImage(MainBitmap);
            paintCore.ArrayPoint.ResetAll();
        }
        private void MainImage_Click(object sender, EventArgs e)
        {
            if (paintCore.MainToolDefiner is MainEnum.Misc)
            {
                if (paintCore.CurrentMisc is ColorPicker)
                {
                    pen.Color = MainBitmap.GetPixel(paintCore.LastPos.X, paintCore.LastPos.Y);
                    UpdateCurrentColors(pen.Color);
                }
                else
                {
                    paintCore.Filter(MainBitmap, pen);
                    scrollablePictureBox.SetImage(MainBitmap);
                }
            }
        }
        private void DrawingTimer_Tick(object sender, EventArgs e)
        {
            CopyBitmap = new(MainBitmap);
            paintCore.DrawOnCopiedBitmap(CopyBitmap, pen);
            scrollablePictureBox.SetImage(CopyBitmap);
            GC.Collect();
        }

        private void MainSelect(object sender, EventArgs e)
        {
            object? tag = ((Button)sender).Tag;

            if (tag is FiguresEnum)
            {
                paintCore.MainToolDefiner = MainEnum.Figures;
                paintCore.CurrentFigure = EnumsHandler.getFigure((FiguresEnum)tag);
            }
            else if (tag is PensilsEnum)
            {
                paintCore.MainToolDefiner = MainEnum.Pensils;
                paintCore.CurrentPensil = EnumsHandler.getPensil((PensilsEnum)tag);
            }
            else if (tag is MiscEnum)
            {
                paintCore.MainToolDefiner = MainEnum.Misc;
                paintCore.CurrentMisc = EnumsHandler.getMisc((MiscEnum)tag);
            }
            ButtonHandler.UnselectAll();
            ButtonHandler.Select((Button)sender);
        }

        #endregion

        #region Other Handlers

        private void ClearBoard_Btn_Click(object sender, EventArgs e)
        {
            if (MainBitmap == null)
                return;

            int w = MainBitmap.Width;
            int h = MainBitmap.Height;

            MainBitmap?.Dispose();
            MainBitmap = paintCore.CreateBitmapBySize(new Size(w, h));
            scrollablePictureBox.SetImage(MainBitmap);
        }

        private void SaveFile_Btn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                MainBitmap.Save(saveFileDialog1.FileName, GetImageFormat(Path.GetExtension(saveFileDialog1.FileName).ToLower().TrimStart('.')));
        }

        private ImageFormat GetImageFormat(string extension) => extension switch
        {
            "jpg" or "jpeg" => ImageFormat.Jpeg,
            "png" => ImageFormat.Png,
            "gif" => ImageFormat.Gif,
            _ => ImageFormat.Bmp,
        };

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                /*if (e.KeyCode == Keys.Z)
                {
                    MainBitmap = paintCore.ReturnToPreviousBitmap(MainBitmap);
                    MainImage.Image = MainBitmap;
                }
                else if (e.KeyCode == Keys.Y)
                {
                    MainBitmap = paintCore.ReturnToFutureBitmap(MainBitmap);
                    MainImage.Image = MainBitmap;
                }
                else */
                if (e.KeyCode == Keys.S)
                    SaveFile_Btn_Click(sender, new EventArgs());
                else if (e.KeyCode == Keys.C)
                    ClearBoard_Btn_Click(sender, new EventArgs());
                else if (e.KeyCode == Keys.O)
                    SelectFile_Btn_Click(sender, new EventArgs());
            }
        }

        private void PenTrackBar_Scroll(object sender, EventArgs e)
        {
            PenHandler.SetPenParameters(pen, PenTrackBar.Value + 1, pen.Color);
            PenWidthLabel.Text = pen.Width.ToString();
        }

        private void Settings_Btn_Click(object sender, EventArgs e)
        {
            SettingsScreen settingsScreen = new SettingsScreen();
            settingsScreen.ThemeChanged += SetUITheme;
            settingsScreen.Show();
        }

        private void NewImage_Btn_Click(object sender, EventArgs e)
        {
            SizeChooseDialog sizeChooseDialog = new();

            sizeChooseDialog.SizeChanged += (_, size) =>
            {
                //if MainBm != null then dispose it
                MainBitmap?.Dispose();
                MainBitmap = paintCore.CreateBitmapBySize(size);
                ProcessPictureBox(size);
            };

            sizeChooseDialog.ShowDialog();
        }

        private void SelectFile_Btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //if MainBm != null then dispose it
                MainBitmap?.Dispose();
                MainBitmap = new Bitmap(openFileDialog1.FileName);
                ProcessPictureBox(new Size(MainBitmap.Width, MainBitmap.Height));
            }
        }
        private void ProcessPictureBox(Size size)
        {
            CalculatePictureBoxSize();

            scrollablePictureBox.SetImage(MainBitmap);
            scrollablePictureBox.SetImageSize(size);
            scrollablePictureBox.Visible = true;

            SizeLabel.Text = $"{size.Width}x{size.Height}";
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (MainBitmap != null)
                CalculatePictureBoxSize();
        }

        private void CalculatePictureBoxSize()
        {
            scrollablePictureBox.Size = new Size(
                Math.Min(MainBitmap.Width, Width - 140),
                Math.Min(MainBitmap.Height, Height - 190) - 80
            );
            CoordinatesLabel.Text = $"{Width}, {Height}";
            scrollablePictureBox.Location = new Point(70, 190);
        }

        #endregion

        #region Color Handlers

        private void ColorHTMLChanged(object sender, KeyPressEventArgs e)
        {
            CurrentColorHTML.Text = CurrentColorHTML.Text.Replace(" ", "");
            if (e.KeyChar == (char)Keys.Enter && CurrentColorHTML.Text != "")
            {
                try
                {
                    Color color = ColorTranslator.FromHtml(CurrentColorHTML.Text);
                    UpdateCurrentColors(color);
                    pen.Color = color;
                }
                catch (ArgumentException)
                {
                    UpdateCurrentColors(pen.Color);
                }
                catch (FormatException)
                {
                    UpdateCurrentColors(pen.Color);
                }
            }
        }

        private void RGBTextboxChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                try
                {
                    Color color = Color.FromArgb(
                        Convert.ToInt32(CurrentColor_R.Text),
                        Convert.ToInt32(CurrentColor_G.Text),
                        Convert.ToInt32(CurrentColor_B.Text));
                    UpdateCurrentColors(color);
                    pen.Color = color;
                }
                catch (ArgumentException)
                {
                    UpdateCurrentColors(pen.Color);
                }
                catch (FormatException)
                {
                    UpdateCurrentColors(pen.Color);
                }
            }
        }

        private void ColorSliderChanged(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(
                ColorSlider_R.Value,
                ColorSlider_G.Value,
                ColorSlider_B.Value);
            UpdateCurrentColors(color);
            pen.Color = color;
        }

        private void UpdateCurrentColors(Color color)
        {
            CurrentColor_R.Text = color.R.ToString();
            CurrentColor_G.Text = color.G.ToString();
            CurrentColor_B.Text = color.B.ToString();
            ColorSlider_R.Value = color.R;
            ColorSlider_G.Value = color.G;
            ColorSlider_B.Value = color.B;
            CurrentColorHTML.Text = ColorTranslator.ToHtml(color);
            CurrentColor.BackColor = color;
        }

        private void SelectColor(object sender, EventArgs e)
        {
            Color color = ((Button)sender).BackColor;
            UpdateCurrentColors(color);
            pen.Color = color;
        }
        #endregion

        #region Button Handlers

        private void SetButtonTags()
        {
            Circle_Btn.Tag = FiguresEnum.Circle;
            Line_Btn.Tag = FiguresEnum.Line;
            Rectangle_Btn.Tag = FiguresEnum.Square;
            RightTriangle_Btn.Tag = FiguresEnum.RightTriangle;
            RegularTriangle_Btn.Tag = FiguresEnum.RegularTriangle;
            StarFive_Btn.Tag = FiguresEnum.StarFive;
            StarSix_Btn.Tag = FiguresEnum.StarSix;
            StarEight_Btn.Tag = FiguresEnum.StarEight;
            Rhombus_Btn.Tag = FiguresEnum.Rhombus;
            Hexagon_Btn.Tag = FiguresEnum.Hexagon;
            Pencil_Btn.Tag = PensilsEnum.Pencil;
            Eraser_Btn.Tag = PensilsEnum.Eraser;
            Filler_Btn.Tag = MiscEnum.Filler;
            ColorPicker_Btn.Tag = MiscEnum.ColorPicker;
        }
        public void InitializeButtons()
        {
            ButtonHandler.Allbuttons.Add(Circle_Btn);
            ButtonHandler.Allbuttons.Add(Rectangle_Btn);
            ButtonHandler.Allbuttons.Add(RegularTriangle_Btn);
            ButtonHandler.Allbuttons.Add(RightTriangle_Btn);
            ButtonHandler.Allbuttons.Add(Line_Btn);
            ButtonHandler.Allbuttons.Add(StarFive_Btn);
            ButtonHandler.Allbuttons.Add(StarSix_Btn);
            ButtonHandler.Allbuttons.Add(StarEight_Btn);
            ButtonHandler.Allbuttons.Add(Rhombus_Btn);
            ButtonHandler.Allbuttons.Add(Hexagon_Btn);
            ButtonHandler.Allbuttons.Add(Pencil_Btn);
            ButtonHandler.Allbuttons.Add(Eraser_Btn);
            ButtonHandler.Allbuttons.Add(Filler_Btn);
            ButtonHandler.Allbuttons.Add(ColorPicker_Btn);
        }

        #endregion

        #region Theme Handlers

        private void SetUITheme()
        {
            bool isLightTheme = ConfigurationManager.AppSettings["UIMode"] == "light";
            SetTheme(isLightTheme);
            GC.Collect();
        }

        Color panelsColor_Light = Color.FromArgb(245, 245, 245);
        Color formColor_Light = Color.FromArgb(205, 205, 205);
        Color mouseOverBackColor_Light = Color.FromArgb(235, 235, 235);
        Color selectColor_Light = Color.FromArgb(205, 205, 205);

        Color panelsColor_Dark = Color.FromArgb(42, 42, 42);
        Color formColor_Dark = Color.FromArgb(24, 24, 24);
        Color mouseOverBackColor_Dark = Color.FromArgb(52, 52, 52);
        Color selectColor_Dark = Color.FromArgb(79, 79, 79);

        private void SetTheme(bool isLightTheme)
        {
            Color foreColor = isLightTheme ? Color.Black : Color.WhiteSmoke;
            Color backColor = isLightTheme ? formColor_Light : formColor_Dark;
            Color panelBackColor = isLightTheme ? panelsColor_Light : panelsColor_Dark;
            Color mouseOverColor = isLightTheme ? mouseOverBackColor_Light : mouseOverBackColor_Dark;
            Color selectColor = isLightTheme ? selectColor_Light : selectColor_Dark;


            ForeColor = foreColor;
            BackColor = backColor;
            panel1.BackColor = panelBackColor;
            panel1.ForeColor = foreColor;
            Settings_Btn.FlatAppearance.BorderColor = panelBackColor;

            SetColorDependencies(panelBackColor, foreColor);

            ButtonHandler.SelectColor = selectColor;
            ButtonHandler.UnselectColor = isLightTheme ? Color.WhiteSmoke : panelBackColor;

            var buttons = new Button[] { SelectFile_Btn, SaveFile_Btn, NewImage_Btn, ClearBoard_Btn, Settings_Btn };
            foreach (var btn in buttons)
            {
                btn.FlatAppearance.MouseOverBackColor = mouseOverColor;
            }

            var buttonImages = new Dictionary<Button, Image>
    {
        { Circle_Btn, isLightTheme ?  Resources.circle : Resources.circle_inverted },
        { Rectangle_Btn, isLightTheme ? Resources.rectangle : Resources.rectangle_inverted },
        { RegularTriangle_Btn, isLightTheme ? Resources.regular_triangle : Resources.regular_triangle_inverted },
        { RightTriangle_Btn, isLightTheme ? Resources.right_triangle : Resources.right_triangle_inverted },
        { Line_Btn, isLightTheme ? Resources.line : Resources.line_inverted },
        { StarFive_Btn, isLightTheme ? Resources.star_five : Resources.star_five_inverted },
        { StarSix_Btn, isLightTheme ? Resources.star_six : Resources.star_six_inverted },
        { StarEight_Btn, isLightTheme ? Resources.star_eight : Resources.star_eight_inverted },
        { Rhombus_Btn, isLightTheme ? Resources.rhombus : Resources.rhombus_inverted },
        { Hexagon_Btn, isLightTheme ? Resources.hexagon : Resources.hexagon_inverted },
        { Filler_Btn, isLightTheme ? Resources.Filler : Resources.filler_inverted },
        { Pencil_Btn, isLightTheme ? Resources.pencil : Resources.pencil_inverted },
        { Eraser_Btn, isLightTheme ? Resources.eraser : Resources.eraser_inverted },
        { ColorPicker_Btn, isLightTheme ? Resources.color_picker : Resources.color_picker_inverted },
        { Settings_Btn, isLightTheme ? Resources.settings : Resources.settings_inverted }
    };

            foreach (var kvp in buttonImages)
            {
                kvp.Key.BackgroundImage = kvp.Value;
            }

            Scribble.BackgroundImage = isLightTheme ? Properties.Resources.scribble : Properties.Resources.scribble_inverted;

            SetWindowTheme(!isLightTheme);
            ButtonHandler.UpdateBtnColors();
        }

        private void SetColorDependencies(Color panelBackColor, Color panelForeColor)
        {
            var controls = new Control[] { CurrentColorHTML, CurrentColor_R, CurrentColor_G, CurrentColor_B, ColorSlider_R, ColorSlider_G, ColorSlider_B, roundPanel1, roundPanel2 };
            foreach (var control in controls)
            {
                control.BackColor = panelBackColor;
                control.ForeColor = panelForeColor;
            }
        }

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetWindowTheme(ConfigurationManager.AppSettings["UIMode"] != "light");
        }
        private void SetWindowTheme(bool dark)
        {
            int[] useDarkMode = dark ? new[] { 1 } : new[] { 0 };
            DwmSetWindowAttribute(Handle, 19, useDarkMode, sizeof(int));
            DwmSetWindowAttribute(Handle, 20, useDarkMode, sizeof(int));
        }
        #endregion
    }
}