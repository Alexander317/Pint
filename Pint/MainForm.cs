using Pint.Core.Enums;
using Pint.Core;
using Pint.Core.Pencils;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using Pint.Core.Misc;
using System.Drawing;

namespace Pint
{
    public partial class MainForm : Form
    {
        #region FIELDS

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

            MainBitmap = new(MainImage.Width, MainImage.Height);
            paintCore.ClearBM(MainBitmap);
            MainImage.Image = MainBitmap;

            SetButtonTags();
            paintCore.MainToolDefiner = MainEnum.Pensils;
            paintCore.CurrentPensil = new Pencil();

            UpdateCurrentColors(pen.Color);
            ButtonHandler.Select(Pencil_Btn);
            InitUI("UIMode");
            trackBar1_Scroll(null, null);
            PenHandler.MakePenRound(pen);
        }

        #region MAIN_IMAGE_HANDLERS

        private void MainImage_MouseDown(object sender, MouseEventArgs e)
        {
            /*paintCore.AddToPreviousBitmaps(MainBitmap);*/
            paintCore.arrayPoint.SetPoint(e.X, e.Y);
            mouseDown = true;
            if (paintCore.MainToolDefiner == MainEnum.Figures)
                DrawingTimer.Enabled = true;
        }
        private void MainImage_MouseMove(object sender, MouseEventArgs e)
        {
            CoordinatesLabel.Text = $"{e.X}, {e.Y}пкс";
            paintCore.PosX = e.X;
            paintCore.PosY = e.Y;
            if (!mouseDown)
                return;


            if (paintCore.MainToolDefiner == MainEnum.Pensils)
            {
                paintCore.Filter(MainBitmap, pen);
                MainImage.Image = MainBitmap;
            }
        }
        private void MainImage_MouseUp(object sender, MouseEventArgs e)
        {
            DrawingTimer.Enabled = false;
            mouseDown = false;
            paintCore.Filter(MainBitmap, pen);
            MainImage.Image = MainBitmap;
            paintCore.arrayPoint.ResetAll();
        }
        private void MainImage_Click(object sender, EventArgs e)
        {
            if (paintCore.MainToolDefiner is MainEnum.Misc)
            {
                if (paintCore.CurrentMisc is ColorPicker)
                {
                    pen.Color = MainBitmap.GetPixel(paintCore.PosX, paintCore.PosY);
                    UpdateCurrentColors(pen.Color);
                } else
                {
                    /*paintCore.AddToPreviousBitmaps(MainBitmap);*/
                    paintCore.Filter(MainBitmap, pen);
                    MainImage.Image = MainBitmap;
                }
            }
        }
        private void DrawingTimer_Tick(object sender, EventArgs e)
        {
            CopyBitmap = new(MainBitmap);
            paintCore.DrawOnCopiedBitmap(CopyBitmap, pen);
            MainImage.Image = CopyBitmap;
            GC.Collect();
        }

        private void MainSelect(object sender, EventArgs e)
        {
            object tag = ((Button)sender).Tag;

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

        #region OTHER_HANDLERS

        private void ClearBoard_Btn_Click(object sender, EventArgs e)
        {
            paintCore.AddToPreviousBitmaps(MainBitmap);
            paintCore.ClearBM(MainBitmap);
            MainImage.Image = MainBitmap;
        }

        private void SaveFile_Btn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG(*.PNG)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                MainImage.Image.Save(saveFileDialog1.FileName);
        }

        private void SelectFile_Btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MainBitmap = new Bitmap(openFileDialog1.FileName);
                MainImage.Image = MainBitmap;
            }
        }

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
                    SaveFile_Btn_Click(sender, null);
                else if (e.KeyCode == Keys.C)
                    ClearBoard_Btn_Click(sender, null);
                else if (e.KeyCode == Keys.O)
                    SelectFile_Btn_Click(sender, null);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PenHandler.SetPenParameters(pen, trackBar1.Value + 1, pen.Color);
            PenWidthLabel.Text = pen.Width.ToString();
        }

        #endregion

        #region COLOR_CONTROL

        private void ColorInHTML_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && CurrentColorInHTML.Text.Replace(" ", "") != "")
            {
                try
                {
                    Color color = ColorTranslator.FromHtml(CurrentColorInHTML.Text.Replace(" ", ""));
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

        private void ColorFromChangingRGBTextboxes(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && ((TextBox)sender).Text.Replace(" ", "") != "")
            {
                try
                {
                    Color color = Color.FromArgb(Convert.ToInt32(CurrentColor_R.Text),
                            Convert.ToInt32(CurrentColor_G.Text), Convert.ToInt32(CurrentColor_B.Text));
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

        private void ColorFromChangingSlider(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(ColorSlider_R.Value, ColorSlider_G.Value, ColorSlider_B.Value);
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
            CurrentColorInHTML.Text = ColorTranslator.ToHtml(color);
            CurrentColor_Btn.BackColor = color;
        }

        private void SelectColor(object sender, EventArgs e)
        {
            Color color = (sender as Button).BackColor;
            UpdateCurrentColors(color);
            pen.Color = color;
        }
        #endregion

        #region BUTTON_HANDLERS

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
            /*TextLabel_Btn.Tag = MiscEnum.TextLabel;*/
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
            /*ButtonHandler.Allbuttons.Add(TextLabel_Btn);*/
        }

        #endregion

        #region THEME_CONTROL
        private void InitUI(string key)
        {
            try
            {
                var uiMode = ConfigurationManager.AppSettings[key];
                if (uiMode == "light")
                {
                    DM_Btn.Text = "Тёмная тема: Выкл";
                    SetLightTheme();
                    ConfigurationManager.AppSettings[key] = "dark";
                }
                else
                {
                    DM_Btn.Text = "Тёмная тема: Вкл";
                    SetDarkTheme();
                    ConfigurationManager.AppSettings[key] = "light";
                }
            }
            catch (Exception e)
            {
                throw;
            }
            GC.Collect();
        }
        private void SetLightTheme()
        {
            ForeColor = Color.Black;
            BackColor = Color.FromArgb(195, 195, 195);
            panel1.BackColor = Color.FromArgb(245, 245, 245);
            panel1.ForeColor = Color.Black;

            SetColorDependencies();

            ButtonHandler.SelectColor = Color.FromArgb(195, 195, 195);
            ButtonHandler.UnselectColor = Color.WhiteSmoke;

            Circle_Btn.BackgroundImage = Properties.Resources.circle;
            Rectangle_Btn.BackgroundImage = Properties.Resources.rectangle;
            RegularTriangle_Btn.BackgroundImage = Properties.Resources.regular_triangle;
            RightTriangle_Btn.BackgroundImage = Properties.Resources.right_triangle;
            Line_Btn.BackgroundImage = Properties.Resources.line;
            StarFive_Btn.BackgroundImage = Properties.Resources.star_five;
            StarSix_Btn.BackgroundImage = Properties.Resources.star_six;
            StarEight_Btn.BackgroundImage = Properties.Resources.star_eight;
            Rhombus_Btn.BackgroundImage = Properties.Resources.rhombus;
            Hexagon_Btn.BackgroundImage = Properties.Resources.hexagon;
            Filler_Btn.BackgroundImage = Properties.Resources.Filler;
            Pencil_Btn.BackgroundImage = Properties.Resources.pencil;
            Eraser_Btn.BackgroundImage = Properties.Resources.eraser;
            ColorPicker_Btn.BackgroundImage = Properties.Resources.color_picker;
            Scribble.BackgroundImage = Properties.Resources.scribble;

            /*Invalidate();*/
            SetWindowTheme(false);
            ButtonHandler.UpdateBtnColors();
        }
        private void SetDarkTheme()
        {
            ForeColor = Color.WhiteSmoke;
            BackColor = Color.FromArgb(17, 24, 34);
            panel1.BackColor = Color.FromArgb(32, 39, 49);
            panel1.ForeColor = Color.WhiteSmoke;

            SetColorDependencies();

            ButtonHandler.SelectColor = Color.FromArgb(87, 94, 104);
            ButtonHandler.UnselectColor = panel1.BackColor;

            Circle_Btn.BackgroundImage = Properties.Resources.circle_inverted;
            Rectangle_Btn.BackgroundImage = Properties.Resources.rectangle_inverted;
            RegularTriangle_Btn.BackgroundImage = Properties.Resources.regular_triangle_inverted;
            RightTriangle_Btn.BackgroundImage = Properties.Resources.right_triangle_inverted;
            Line_Btn.BackgroundImage = Properties.Resources.line_inverted;
            StarFive_Btn.BackgroundImage = Properties.Resources.star_five_inverted;
            StarSix_Btn.BackgroundImage = Properties.Resources.star_six_inverted;
            StarEight_Btn.BackgroundImage = Properties.Resources.star_eight_inverted;
            Rhombus_Btn.BackgroundImage = Properties.Resources.rhombus_inverted;
            Hexagon_Btn.BackgroundImage = Properties.Resources.hexagon_inverted;
            Filler_Btn.BackgroundImage = Properties.Resources.filler_inverted;
            Pencil_Btn.BackgroundImage = Properties.Resources.pencil_inverted;
            Eraser_Btn.BackgroundImage = Properties.Resources.eraser_inverted;
            ColorPicker_Btn.BackgroundImage = Properties.Resources.color_picker_inverted;
            Scribble.BackgroundImage = Properties.Resources.scribble_inverted;

            /*Invalidate();*/
            SetWindowTheme(true);
            ButtonHandler.UpdateBtnColors();
        }

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            var uiMode = ConfigurationManager.AppSettings["UIMode"];
            SetWindowTheme(uiMode != "light");
        }
        private void SetWindowTheme(bool dark)
        {
            int[] useDarkMode = dark ? new[] { 1 } : new[] { 0 };
            DwmSetWindowAttribute(Handle, 19, useDarkMode, sizeof(int));
            DwmSetWindowAttribute(Handle, 20, useDarkMode, sizeof(int));
        }

        private void SetColorDependencies()
        {
            CurrentColorInHTML.BackColor = panel1.BackColor;
            CurrentColor_R.BackColor = panel1.BackColor;
            CurrentColor_G.BackColor = panel1.BackColor;
            CurrentColor_B.BackColor = panel1.BackColor;

            CurrentColorInHTML.ForeColor = panel1.ForeColor;
            CurrentColor_R.ForeColor = panel1.ForeColor;
            CurrentColor_G.ForeColor = panel1.ForeColor;
            CurrentColor_B.ForeColor = panel1.ForeColor;
            ColorSlider_R.BackColor = panel1.BackColor;
            ColorSlider_G.BackColor = panel1.BackColor;
            ColorSlider_B.BackColor = panel1.BackColor;
            panel5.BackColor = panel1.BackColor;
            panel5.ForeColor = panel1.ForeColor;
        }

        private void DM_Btn_Click(object sender, EventArgs e)
        {
            InitUI("UIMode");
        }
        #endregion
    }
}