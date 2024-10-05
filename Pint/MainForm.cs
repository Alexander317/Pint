using Pint.Core.Enums;
using Pint.Core;
using Pint.Core.Pencils;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using Pint.Core.Misc;
using Pint.Properties;
using Pint.AdditionalToolbox;

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

            MainImage.GetPictureBox().MouseDown += MainImage_MouseDown;
            MainImage.GetPictureBox().MouseMove += MainImage_MouseMove;
            MainImage.GetPictureBox().MouseUp += MainImage_MouseUp;
            MainImage.GetPictureBox().MouseClick += MainImage_MouseClick;

            SetButtonTags();
            paintCore.MainToolDefiner = MainEnum.Pensils;
            paintCore.CurrentPensil = new Pencil();

            UpdateCurrentColors(pen.Color);
            ButtonHandler.Select(Pencil_Btn);
            SetUITheme();
            PenTrackBar_Scroll(new object(), EventArgs.Empty);
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
                MainImage.SetImage(MainBitmap);
            }
        }
        private void MainImage_MouseUp(object sender, MouseEventArgs e)
        {
            DrawingTimer.Enabled = false;
            mouseDown = false;
            CopyBitmap?.Dispose();
            paintCore.Filter(MainBitmap, pen);
            MainImage.SetImage(MainBitmap);
            paintCore.ArrayPoint.ResetAll();
        }
        private void MainImage_MouseClick(object sender, EventArgs e)
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
                    MainImage.SetImage(MainBitmap);
                }
            }
        }
        private void DrawingTimer_Tick(object sender, EventArgs e)
        {
            CopyBitmap = new(MainBitmap);
            paintCore.DrawOnCopiedBitmap(CopyBitmap, pen);
            MainImage.SetImage(CopyBitmap);
            GC.Collect();
        }

        #endregion

        #region Other Handlers

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

        private void ClearImageButton_Click(object sender, EventArgs e)
        {
            if (MainBitmap == null)
                return;

            int BackupWidth = MainBitmap.Width;
            int BackupHeight = MainBitmap.Height;

            MainBitmap?.Dispose();
            MainBitmap = paintCore.CreateBitmap(new Size(BackupWidth, BackupHeight));
            MainImage.SetImage(MainBitmap);
        }

        private void ExportImageButton_Click(object sender, EventArgs e)
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
                    ExportImageButton_Click(sender, new EventArgs());
                else if (e.KeyCode == Keys.C)
                    ClearImageButton_Click(sender, new EventArgs());
                else if (e.KeyCode == Keys.O)
                    ImportImageButton_Click(sender, new EventArgs());
            }
        }

        private void PenTrackBar_Scroll(object sender, EventArgs e)
        {
            PenHandler.SetPenParameters(pen, PenTrackBar.Value + 1, pen.Color);
            PenWidthLabel.Text = pen.Width.ToString();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsScreen settingsScreen = new SettingsScreen();
            settingsScreen.ThemeChanged += SetUITheme;
            settingsScreen.Show();
        }

        private void NewImageButton_Click(object sender, EventArgs e)
        {
            SizeChooseDialog sizeChooseDialog = new();

            sizeChooseDialog.SizeChanged += (_, size) =>
            {
                //if MainBm != null then dispose it
                MainBitmap?.Dispose();
                MainBitmap = paintCore.CreateBitmap(size);
                ProcessPictureBox(size);
            };

            sizeChooseDialog.ShowDialog();
        }

        private void ImportImageButton_Click(object sender, EventArgs e)
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
            MainImage.SetImage(MainBitmap);
            MainImageCalculations();
            MainImage.Visible = true;

            SizeLabel.Text = $"{size.Width}x{size.Height}";
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (MainBitmap != null)
                MainImageCalculations();
        }

        private void MainImageCalculations()
        {
            var ImageWidth = MainImage.GetImage().Width;
            var ImageHeight = MainImage.GetImage().Height;

            var availableWidth = Width - 160;
            var availableHeight = Height - 270;

            //Location
            MainImage.Location = new Point(ImageWidth > availableWidth ? 72 : (Width / 2) - (ImageWidth / 2),
                                           ImageHeight > availableHeight ? 190 : (Height / 2) - (ImageHeight / 2) + 65);

            //Control Size
            MainImage.Size = new Size(ImageWidth > availableWidth ? availableWidth : ImageWidth,
                                      ImageHeight > availableHeight ? availableHeight : ImageHeight);
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
            ButtonHandler.Buttons.Add(Circle_Btn);
            ButtonHandler.Buttons.Add(Rectangle_Btn);
            ButtonHandler.Buttons.Add(RegularTriangle_Btn);
            ButtonHandler.Buttons.Add(RightTriangle_Btn);
            ButtonHandler.Buttons.Add(Line_Btn);
            ButtonHandler.Buttons.Add(StarFive_Btn);
            ButtonHandler.Buttons.Add(StarSix_Btn);
            ButtonHandler.Buttons.Add(StarEight_Btn);
            ButtonHandler.Buttons.Add(Rhombus_Btn);
            ButtonHandler.Buttons.Add(Hexagon_Btn);
            ButtonHandler.Buttons.Add(Pencil_Btn);
            ButtonHandler.Buttons.Add(Eraser_Btn);
            ButtonHandler.Buttons.Add(Filler_Btn);
            ButtonHandler.Buttons.Add(Settings_Btn);
            ButtonHandler.Buttons.Add(ColorPicker_Btn);
        }

        public void DrawOnButtons(Color color)
        {
            ButtonHandler.SetArrayPoint();
            foreach (var btn in ButtonHandler.Buttons)
            {
                if (btn.Tag is FiguresEnum)
                    ButtonHandler.DrawOnButton(btn, color);
            }
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
        Color mouseOverBackColor_Light = Color.FromArgb(230, 230, 230);
        Color mouseDownBackColor_Light = Color.FromArgb(220, 220, 220);
        Color selectColor_Light = Color.FromArgb(205, 205, 205);

        Color panelsColor_Dark = Color.FromArgb(42, 42, 42);
        Color formColor_Dark = Color.FromArgb(24, 24, 24);
        Color mouseOverBackColor_Dark = Color.FromArgb(57, 57, 57);
        Color mouseDownBackColor_Dark = Color.FromArgb(67, 67, 67);
        Color selectColor_Dark = Color.FromArgb(79, 79, 79);

        private void SetTheme(bool isLightTheme)
        {
            Color foreColor = isLightTheme ? Color.Black : Color.WhiteSmoke;
            Color backColor = isLightTheme ? formColor_Light : formColor_Dark;
            Color panelBackColor = isLightTheme ? panelsColor_Light : panelsColor_Dark;
            Color mouseOverColor = isLightTheme ? mouseOverBackColor_Light : mouseOverBackColor_Dark;
            Color mouseDownColor = isLightTheme ? mouseDownBackColor_Light : mouseDownBackColor_Dark;
            Color selectColor = isLightTheme ? selectColor_Light : selectColor_Dark;
            Color linesColor = !isLightTheme ? selectColor_Light : selectColor_Dark;

            ForeColor = foreColor;
            BackColor = backColor;
            panel1.BackColor = panelBackColor;
            panel1.ForeColor = foreColor;
            ButtonHandler.SelectColor = selectColor;
            Settings_Btn.FlatAppearance.BorderColor = panelBackColor;

            SetLinesColor(linesColor);
            SetControlImages(isLightTheme, foreColor);
            SetControlColor(panelBackColor, foreColor);
            SetBorderColor(Color.FromArgb(panelBackColor.R - 10, panelBackColor.G - 10, panelBackColor.B - 10));
            SetMouseOverColor(mouseOverColor);
            SetMouseDownColor(mouseDownColor);

            SetWindowTheme(!isLightTheme);

            ButtonHandler.UpdateBtnColors();
        }
        private void SetMouseOverColor(Color mouseOverColor)
        {
            foreach (var btn in ButtonHandler.Buttons)
                btn.FlatAppearance.MouseOverBackColor = mouseOverColor;

            var Buttons = new Button[] { NewImageButton, ClearImageButton, ImportImageButton, ExportImageButton };
            foreach (var btn in Buttons)
                btn.FlatAppearance.MouseOverBackColor = mouseOverColor;
        }
        private void SetMouseDownColor(Color mouseDownColor)
        {
            foreach (var btn in ButtonHandler.Buttons)
                btn.FlatAppearance.MouseDownBackColor = mouseDownColor;

            var Buttons = new Button[] { NewImageButton, ClearImageButton, ImportImageButton, ExportImageButton };
            foreach (var btn in Buttons)
                btn.FlatAppearance.MouseDownBackColor = mouseDownColor;
        }
        private void SetLinesColor(Color linesColor)
        {
            var lines = new LineControl[] { rotatableLineControl1, rotatableLineControl2, rotatableLineControl3 };
            foreach (var line in lines)
                line.Color = linesColor;
        }
        private void SetControlImages(bool isLightTheme, Color buttonImageColor)
        {
            DrawOnButtons(buttonImageColor);
            var buttonImages = new Dictionary<Control, Image>
            {
                { Filler_Btn, isLightTheme ? Resources.Filler : Resources.filler_inverted },
                { Pencil_Btn, isLightTheme ? Resources.pencil : Resources.pencil_inverted },
                { Eraser_Btn, isLightTheme ? Resources.eraser : Resources.eraser_inverted },
                { ColorPicker_Btn, isLightTheme ? Resources.color_picker : Resources.color_picker_inverted },
                { Scribble, isLightTheme ? Resources.scribble : Resources.scribble_inverted },
                { Settings_Btn, isLightTheme ? Resources.settings : Resources.settings_inverted }
            };
            foreach (var kvp in buttonImages)
                kvp.Key.BackgroundImage = kvp.Value;
        }
        private void SetBorderColor(Color borderColor)
        {
            var Buttons = new RoundButton[] { NewImageButton, ClearImageButton, ImportImageButton, ExportImageButton }; 
            foreach (var btn in Buttons)
                btn.FlatAppearance.BorderColor = borderColor;
        }
        private void SetControlColor(Color panelBackColor, Color foreColor)
        {
            var controls = new Control[] { CurrentColorHTML, CurrentColor_R, CurrentColor_G, CurrentColor_B, ColorSlider_R, ColorSlider_G, ColorSlider_B, roundPanel1, roundPanel2 };
            var controls1 = new Control[] { NewImageButton, ClearImageButton, ImportImageButton, ExportImageButton };
            foreach (var control in controls)
            {
                control.BackColor = panelBackColor;
                control.ForeColor = foreColor;
            }
            foreach (var control in controls1)
            {
                control.BackColor = Color.FromArgb(panelBackColor.R - 10, panelBackColor.G - 10, panelBackColor.B - 10);
                control.ForeColor = foreColor;
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