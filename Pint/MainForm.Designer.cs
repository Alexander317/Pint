using Pint.AdditionalToolbox;
using Pint.Properties;

namespace Pint
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel4 = new Panel();
            ColorPicker_Btn = new RoundButton();
            Filler_Btn = new RoundButton();
            label4 = new Label();
            Pencil_Btn = new RoundButton();
            Eraser_Btn = new RoundButton();
            label3 = new Label();
            Hexagon_Btn = new RoundButton();
            Rhombus_Btn = new RoundButton();
            StarEight_Btn = new RoundButton();
            StarSix_Btn = new RoundButton();
            StarFive_Btn = new RoundButton();
            RegularTriangle_Btn = new RoundButton();
            RightTriangle_Btn = new RoundButton();
            Line_Btn = new RoundButton();
            Circle_Btn = new RoundButton();
            Rectangle_Btn = new RoundButton();
            label1 = new Label();
            panel2 = new Panel();
            rotatableLineControl3 = new LineControl();
            CurrentColor = new PictureBox();
            rotatableLineControl1 = new LineControl();
            DeepPink_Btn = new Button();
            Navy_Btn = new Button();
            Sienna_Btn = new Button();
            Goldenrod_Btn = new Button();
            Crimson_Btn = new Button();
            DarkGreen_Btn = new Button();
            Tomato_Btn = new Button();
            DarkOrange_Btn = new Button();
            SteelBlue_Btn = new Button();
            LightGray_Btn = new Button();
            Purple_Btn = new Button();
            Blue_Btn = new Button();
            CurrentColorHTML = new TextBox();
            HotPink_Btn = new Button();
            ColorSlider_R = new TrackBar();
            Orange_Btn = new Button();
            CurrentColor_B = new TextBox();
            BlueViolet_Btn = new Button();
            ColorSlider_G = new TrackBar();
            LimeGreen_Btn = new Button();
            CurrentColor_G = new TextBox();
            DeepSkyBlue_Btn = new Button();
            ColorSlider_B = new TrackBar();
            Fuchsia_Btn = new Button();
            CurrentColor_R = new TextBox();
            RoyalBlue_Btn = new Button();
            label6 = new Label();
            Gray_Btn = new Button();
            label8 = new Label();
            Gold_Btn = new Button();
            label7 = new Label();
            LawnGreen_Btn = new Button();
            Chocolate_Btn = new Button();
            Red_Btn = new Button();
            Yellow_Btn = new Button();
            Black_Btn = new Button();
            Cyan_Btn = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            ExportImageButton = new RoundButton();
            NewImageButton = new RoundButton();
            label2 = new Label();
            ClearImageButton = new RoundButton();
            ImportImageButton = new RoundButton();
            Settings_Btn = new RoundButton();
            panel6 = new Panel();
            rotatableLineControl2 = new LineControl();
            DrawingTimer = new System.Windows.Forms.Timer(components);
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            CoordinatesLabel = new Label();
            SizeLabel = new Label();
            roundPanel1 = new RoundPanel();
            PenWidthLabel = new Label();
            Scribble = new PictureBox();
            PenTrackBar = new TrackBar();
            roundPanel2 = new RoundPanel();
            MainImage = new ScrollablePictureBox();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CurrentColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_B).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Scribble).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PenTrackBar).BeginInit();
            roundPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(ColorPicker_Btn);
            panel4.Controls.Add(Filler_Btn);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(Pencil_Btn);
            panel4.Controls.Add(Eraser_Btn);
            panel4.Location = new Point(225, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(116, 150);
            panel4.TabIndex = 33;
            // 
            // ColorPicker_Btn
            // 
            ColorPicker_Btn.Anchor = AnchorStyles.None;
            ColorPicker_Btn.BackColor = Color.Transparent;
            ColorPicker_Btn.BackgroundImage = Resources.color_picker;
            ColorPicker_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            ColorPicker_Btn.BorderRadius = 4;
            ColorPicker_Btn.BorderWidth = 0F;
            ColorPicker_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ColorPicker_Btn.FlatAppearance.BorderSize = 0;
            ColorPicker_Btn.FlatStyle = FlatStyle.Flat;
            ColorPicker_Btn.ForeColor = Color.Black;
            ColorPicker_Btn.Location = new Point(61, 71);
            ColorPicker_Btn.Name = "ColorPicker_Btn";
            ColorPicker_Btn.RoundBottomLeft = true;
            ColorPicker_Btn.RoundBottomRight = true;
            ColorPicker_Btn.RoundTopLeft = true;
            ColorPicker_Btn.RoundTopRight = true;
            ColorPicker_Btn.Size = new Size(35, 35);
            ColorPicker_Btn.TabIndex = 4;
            ColorPicker_Btn.UseVisualStyleBackColor = false;
            ColorPicker_Btn.Click += MainSelect;
            // 
            // Filler_Btn
            // 
            Filler_Btn.Anchor = AnchorStyles.None;
            Filler_Btn.BackColor = Color.Transparent;
            Filler_Btn.BackgroundImage = Resources.Filler;
            Filler_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Filler_Btn.BorderRadius = 4;
            Filler_Btn.BorderWidth = 0F;
            Filler_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Filler_Btn.FlatAppearance.BorderSize = 0;
            Filler_Btn.FlatStyle = FlatStyle.Flat;
            Filler_Btn.ForeColor = Color.Black;
            Filler_Btn.Location = new Point(20, 71);
            Filler_Btn.Name = "Filler_Btn";
            Filler_Btn.RoundBottomLeft = true;
            Filler_Btn.RoundBottomRight = true;
            Filler_Btn.RoundTopLeft = true;
            Filler_Btn.RoundTopRight = true;
            Filler_Btn.Size = new Size(35, 35);
            Filler_Btn.TabIndex = 3;
            Filler_Btn.UseVisualStyleBackColor = false;
            Filler_Btn.Click += MainSelect;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(-3, 121);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 32;
            label4.Text = "Инструменты";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pencil_Btn
            // 
            Pencil_Btn.Anchor = AnchorStyles.None;
            Pencil_Btn.BackColor = Color.Transparent;
            Pencil_Btn.BackgroundImage = Resources.pencil;
            Pencil_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Pencil_Btn.BorderRadius = 4;
            Pencil_Btn.BorderWidth = 0F;
            Pencil_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Pencil_Btn.FlatAppearance.BorderSize = 0;
            Pencil_Btn.FlatStyle = FlatStyle.Flat;
            Pencil_Btn.ForeColor = Color.Black;
            Pencil_Btn.Location = new Point(61, 35);
            Pencil_Btn.Name = "Pencil_Btn";
            Pencil_Btn.RoundBottomLeft = true;
            Pencil_Btn.RoundBottomRight = true;
            Pencil_Btn.RoundTopLeft = true;
            Pencil_Btn.RoundTopRight = true;
            Pencil_Btn.Size = new Size(35, 35);
            Pencil_Btn.TabIndex = 2;
            Pencil_Btn.UseVisualStyleBackColor = false;
            Pencil_Btn.Click += MainSelect;
            // 
            // Eraser_Btn
            // 
            Eraser_Btn.Anchor = AnchorStyles.None;
            Eraser_Btn.BackColor = Color.Transparent;
            Eraser_Btn.BackgroundImage = Resources.eraser;
            Eraser_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Eraser_Btn.BorderRadius = 4;
            Eraser_Btn.BorderWidth = 0F;
            Eraser_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Eraser_Btn.FlatAppearance.BorderSize = 0;
            Eraser_Btn.FlatStyle = FlatStyle.Flat;
            Eraser_Btn.ForeColor = Color.Black;
            Eraser_Btn.Location = new Point(20, 35);
            Eraser_Btn.Name = "Eraser_Btn";
            Eraser_Btn.RoundBottomLeft = true;
            Eraser_Btn.RoundBottomRight = true;
            Eraser_Btn.RoundTopLeft = true;
            Eraser_Btn.RoundTopRight = true;
            Eraser_Btn.Size = new Size(35, 35);
            Eraser_Btn.TabIndex = 1;
            Eraser_Btn.UseVisualStyleBackColor = false;
            Eraser_Btn.Click += MainSelect;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(40, 121);
            label3.Name = "label3";
            label3.Size = new Size(141, 28);
            label3.TabIndex = 31;
            label3.Text = "Фигуры";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Hexagon_Btn
            // 
            Hexagon_Btn.Anchor = AnchorStyles.None;
            Hexagon_Btn.BackColor = Color.Transparent;
            Hexagon_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Hexagon_Btn.BorderRadius = 4;
            Hexagon_Btn.BorderWidth = 0F;
            Hexagon_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Hexagon_Btn.FlatAppearance.BorderSize = 0;
            Hexagon_Btn.FlatStyle = FlatStyle.Flat;
            Hexagon_Btn.ForeColor = Color.Black;
            Hexagon_Btn.Location = new Point(172, 72);
            Hexagon_Btn.Name = "Hexagon_Btn";
            Hexagon_Btn.RoundBottomLeft = true;
            Hexagon_Btn.RoundBottomRight = true;
            Hexagon_Btn.RoundTopLeft = true;
            Hexagon_Btn.RoundTopRight = true;
            Hexagon_Btn.Size = new Size(35, 35);
            Hexagon_Btn.TabIndex = 10;
            Hexagon_Btn.Tag = "";
            Hexagon_Btn.UseVisualStyleBackColor = false;
            Hexagon_Btn.Click += MainSelect;
            // 
            // Rhombus_Btn
            // 
            Rhombus_Btn.Anchor = AnchorStyles.None;
            Rhombus_Btn.BackColor = Color.Transparent;
            Rhombus_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Rhombus_Btn.BorderRadius = 4;
            Rhombus_Btn.BorderWidth = 0F;
            Rhombus_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Rhombus_Btn.FlatAppearance.BorderSize = 0;
            Rhombus_Btn.FlatStyle = FlatStyle.Flat;
            Rhombus_Btn.ForeColor = Color.Black;
            Rhombus_Btn.Location = new Point(131, 72);
            Rhombus_Btn.Name = "Rhombus_Btn";
            Rhombus_Btn.RoundBottomLeft = true;
            Rhombus_Btn.RoundBottomRight = true;
            Rhombus_Btn.RoundTopLeft = true;
            Rhombus_Btn.RoundTopRight = true;
            Rhombus_Btn.Size = new Size(35, 35);
            Rhombus_Btn.TabIndex = 9;
            Rhombus_Btn.Tag = "";
            Rhombus_Btn.UseVisualStyleBackColor = false;
            Rhombus_Btn.Click += MainSelect;
            // 
            // StarEight_Btn
            // 
            StarEight_Btn.Anchor = AnchorStyles.None;
            StarEight_Btn.BackColor = Color.Transparent;
            StarEight_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            StarEight_Btn.BorderRadius = 4;
            StarEight_Btn.BorderWidth = 0F;
            StarEight_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            StarEight_Btn.FlatAppearance.BorderSize = 0;
            StarEight_Btn.FlatStyle = FlatStyle.Flat;
            StarEight_Btn.ForeColor = Color.Black;
            StarEight_Btn.Location = new Point(90, 72);
            StarEight_Btn.Name = "StarEight_Btn";
            StarEight_Btn.RoundBottomLeft = true;
            StarEight_Btn.RoundBottomRight = true;
            StarEight_Btn.RoundTopLeft = true;
            StarEight_Btn.RoundTopRight = true;
            StarEight_Btn.Size = new Size(35, 35);
            StarEight_Btn.TabIndex = 8;
            StarEight_Btn.Tag = "";
            StarEight_Btn.UseVisualStyleBackColor = false;
            StarEight_Btn.Click += MainSelect;
            // 
            // StarSix_Btn
            // 
            StarSix_Btn.Anchor = AnchorStyles.None;
            StarSix_Btn.BackColor = Color.Transparent;
            StarSix_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            StarSix_Btn.BorderRadius = 4;
            StarSix_Btn.BorderWidth = 0F;
            StarSix_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            StarSix_Btn.FlatAppearance.BorderSize = 0;
            StarSix_Btn.FlatStyle = FlatStyle.Flat;
            StarSix_Btn.ForeColor = Color.Black;
            StarSix_Btn.Location = new Point(49, 72);
            StarSix_Btn.Name = "StarSix_Btn";
            StarSix_Btn.RoundBottomLeft = true;
            StarSix_Btn.RoundBottomRight = true;
            StarSix_Btn.RoundTopLeft = true;
            StarSix_Btn.RoundTopRight = true;
            StarSix_Btn.Size = new Size(35, 35);
            StarSix_Btn.TabIndex = 7;
            StarSix_Btn.Tag = "";
            StarSix_Btn.UseVisualStyleBackColor = false;
            StarSix_Btn.Click += MainSelect;
            // 
            // StarFive_Btn
            // 
            StarFive_Btn.Anchor = AnchorStyles.None;
            StarFive_Btn.BackColor = Color.Transparent;
            StarFive_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            StarFive_Btn.BorderRadius = 4;
            StarFive_Btn.BorderWidth = 0F;
            StarFive_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            StarFive_Btn.FlatAppearance.BorderSize = 0;
            StarFive_Btn.FlatStyle = FlatStyle.Flat;
            StarFive_Btn.ForeColor = Color.Black;
            StarFive_Btn.Location = new Point(8, 72);
            StarFive_Btn.Name = "StarFive_Btn";
            StarFive_Btn.RoundBottomLeft = true;
            StarFive_Btn.RoundBottomRight = true;
            StarFive_Btn.RoundTopLeft = true;
            StarFive_Btn.RoundTopRight = true;
            StarFive_Btn.Size = new Size(35, 35);
            StarFive_Btn.TabIndex = 6;
            StarFive_Btn.Tag = "";
            StarFive_Btn.UseVisualStyleBackColor = false;
            StarFive_Btn.Click += MainSelect;
            // 
            // RegularTriangle_Btn
            // 
            RegularTriangle_Btn.Anchor = AnchorStyles.None;
            RegularTriangle_Btn.BackColor = Color.Transparent;
            RegularTriangle_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            RegularTriangle_Btn.BorderRadius = 4;
            RegularTriangle_Btn.BorderWidth = 0F;
            RegularTriangle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RegularTriangle_Btn.FlatAppearance.BorderSize = 0;
            RegularTriangle_Btn.FlatStyle = FlatStyle.Flat;
            RegularTriangle_Btn.ForeColor = Color.Black;
            RegularTriangle_Btn.Location = new Point(49, 36);
            RegularTriangle_Btn.Name = "RegularTriangle_Btn";
            RegularTriangle_Btn.RoundBottomLeft = true;
            RegularTriangle_Btn.RoundBottomRight = true;
            RegularTriangle_Btn.RoundTopLeft = true;
            RegularTriangle_Btn.RoundTopRight = true;
            RegularTriangle_Btn.Size = new Size(35, 35);
            RegularTriangle_Btn.TabIndex = 5;
            RegularTriangle_Btn.Tag = "";
            RegularTriangle_Btn.UseVisualStyleBackColor = false;
            RegularTriangle_Btn.Click += MainSelect;
            // 
            // RightTriangle_Btn
            // 
            RightTriangle_Btn.Anchor = AnchorStyles.None;
            RightTriangle_Btn.BackColor = Color.Transparent;
            RightTriangle_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            RightTriangle_Btn.BorderRadius = 4;
            RightTriangle_Btn.BorderWidth = 0F;
            RightTriangle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RightTriangle_Btn.FlatAppearance.BorderSize = 0;
            RightTriangle_Btn.FlatStyle = FlatStyle.Flat;
            RightTriangle_Btn.ForeColor = Color.Black;
            RightTriangle_Btn.Location = new Point(131, 36);
            RightTriangle_Btn.Name = "RightTriangle_Btn";
            RightTriangle_Btn.RoundBottomLeft = true;
            RightTriangle_Btn.RoundBottomRight = true;
            RightTriangle_Btn.RoundTopLeft = true;
            RightTriangle_Btn.RoundTopRight = true;
            RightTriangle_Btn.Size = new Size(35, 35);
            RightTriangle_Btn.TabIndex = 4;
            RightTriangle_Btn.Tag = "";
            RightTriangle_Btn.UseVisualStyleBackColor = false;
            RightTriangle_Btn.Click += MainSelect;
            // 
            // Line_Btn
            // 
            Line_Btn.Anchor = AnchorStyles.None;
            Line_Btn.BackColor = Color.Transparent;
            Line_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Line_Btn.BorderRadius = 4;
            Line_Btn.BorderWidth = 0F;
            Line_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Line_Btn.FlatAppearance.BorderSize = 0;
            Line_Btn.FlatStyle = FlatStyle.Flat;
            Line_Btn.ForeColor = Color.Black;
            Line_Btn.Location = new Point(172, 35);
            Line_Btn.Name = "Line_Btn";
            Line_Btn.RoundBottomLeft = true;
            Line_Btn.RoundBottomRight = true;
            Line_Btn.RoundTopLeft = true;
            Line_Btn.RoundTopRight = true;
            Line_Btn.Size = new Size(35, 35);
            Line_Btn.TabIndex = 3;
            Line_Btn.Tag = "";
            Line_Btn.UseVisualStyleBackColor = false;
            Line_Btn.Click += MainSelect;
            // 
            // Circle_Btn
            // 
            Circle_Btn.Anchor = AnchorStyles.None;
            Circle_Btn.BackColor = Color.Transparent;
            Circle_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Circle_Btn.BorderRadius = 4;
            Circle_Btn.BorderWidth = 0F;
            Circle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Circle_Btn.FlatAppearance.BorderSize = 0;
            Circle_Btn.FlatStyle = FlatStyle.Flat;
            Circle_Btn.ForeColor = Color.Black;
            Circle_Btn.Location = new Point(8, 35);
            Circle_Btn.Name = "Circle_Btn";
            Circle_Btn.RoundBottomLeft = true;
            Circle_Btn.RoundBottomRight = true;
            Circle_Btn.RoundTopLeft = true;
            Circle_Btn.RoundTopRight = true;
            Circle_Btn.Size = new Size(35, 35);
            Circle_Btn.TabIndex = 2;
            Circle_Btn.Tag = "";
            Circle_Btn.UseVisualStyleBackColor = false;
            Circle_Btn.Click += MainSelect;
            // 
            // Rectangle_Btn
            // 
            Rectangle_Btn.Anchor = AnchorStyles.None;
            Rectangle_Btn.BackColor = Color.Transparent;
            Rectangle_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Rectangle_Btn.BorderRadius = 4;
            Rectangle_Btn.BorderWidth = 0F;
            Rectangle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Rectangle_Btn.FlatAppearance.BorderSize = 0;
            Rectangle_Btn.FlatStyle = FlatStyle.Flat;
            Rectangle_Btn.ForeColor = Color.Black;
            Rectangle_Btn.Location = new Point(90, 36);
            Rectangle_Btn.Name = "Rectangle_Btn";
            Rectangle_Btn.RoundBottomLeft = true;
            Rectangle_Btn.RoundBottomRight = true;
            Rectangle_Btn.RoundTopLeft = true;
            Rectangle_Btn.RoundTopRight = true;
            Rectangle_Btn.Size = new Size(35, 35);
            Rectangle_Btn.TabIndex = 1;
            Rectangle_Btn.Tag = "";
            Rectangle_Btn.UseVisualStyleBackColor = false;
            Rectangle_Btn.Click += MainSelect;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(226, 123);
            label1.Name = "label1";
            label1.Size = new Size(128, 26);
            label1.TabIndex = 26;
            label1.Text = "Палитра";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(rotatableLineControl3);
            panel2.Controls.Add(CurrentColor);
            panel2.Controls.Add(rotatableLineControl1);
            panel2.Controls.Add(DeepPink_Btn);
            panel2.Controls.Add(Navy_Btn);
            panel2.Controls.Add(Sienna_Btn);
            panel2.Controls.Add(Goldenrod_Btn);
            panel2.Controls.Add(Crimson_Btn);
            panel2.Controls.Add(DarkGreen_Btn);
            panel2.Controls.Add(Tomato_Btn);
            panel2.Controls.Add(DarkOrange_Btn);
            panel2.Controls.Add(SteelBlue_Btn);
            panel2.Controls.Add(LightGray_Btn);
            panel2.Controls.Add(Purple_Btn);
            panel2.Controls.Add(Blue_Btn);
            panel2.Controls.Add(CurrentColorHTML);
            panel2.Controls.Add(HotPink_Btn);
            panel2.Controls.Add(ColorSlider_R);
            panel2.Controls.Add(Orange_Btn);
            panel2.Controls.Add(CurrentColor_B);
            panel2.Controls.Add(BlueViolet_Btn);
            panel2.Controls.Add(ColorSlider_G);
            panel2.Controls.Add(LimeGreen_Btn);
            panel2.Controls.Add(CurrentColor_G);
            panel2.Controls.Add(DeepSkyBlue_Btn);
            panel2.Controls.Add(ColorSlider_B);
            panel2.Controls.Add(Fuchsia_Btn);
            panel2.Controls.Add(CurrentColor_R);
            panel2.Controls.Add(RoyalBlue_Btn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Gray_Btn);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(Gold_Btn);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(LawnGreen_Btn);
            panel2.Controls.Add(Chocolate_Btn);
            panel2.Controls.Add(Red_Btn);
            panel2.Controls.Add(Yellow_Btn);
            panel2.Controls.Add(Black_Btn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Cyan_Btn);
            panel2.Location = new Point(340, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 150);
            panel2.TabIndex = 25;
            // 
            // rotatableLineControl3
            // 
            rotatableLineControl3.Color = Color.Black;
            rotatableLineControl3.LineWidth = 2F;
            rotatableLineControl3.Location = new Point(542, 0);
            rotatableLineControl3.Name = "rotatableLineControl3";
            rotatableLineControl3.RotationAngle = 0F;
            rotatableLineControl3.Size = new Size(10, 150);
            rotatableLineControl3.TabIndex = 64;
            // 
            // CurrentColor
            // 
            CurrentColor.BackColor = Color.Transparent;
            CurrentColor.BackgroundImageLayout = ImageLayout.Stretch;
            CurrentColor.Location = new Point(324, 8);
            CurrentColor.Name = "CurrentColor";
            CurrentColor.Size = new Size(89, 23);
            CurrentColor.TabIndex = 69;
            CurrentColor.TabStop = false;
            // 
            // rotatableLineControl1
            // 
            rotatableLineControl1.Color = Color.Black;
            rotatableLineControl1.LineWidth = 2F;
            rotatableLineControl1.Location = new Point(-2, 0);
            rotatableLineControl1.Name = "rotatableLineControl1";
            rotatableLineControl1.RotationAngle = 0F;
            rotatableLineControl1.Size = new Size(10, 150);
            rotatableLineControl1.TabIndex = 32;
            // 
            // DeepPink_Btn
            // 
            DeepPink_Btn.Anchor = AnchorStyles.None;
            DeepPink_Btn.BackColor = Color.DeepPink;
            DeepPink_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DeepPink_Btn.FlatAppearance.BorderSize = 0;
            DeepPink_Btn.FlatStyle = FlatStyle.Popup;
            DeepPink_Btn.Location = new Point(235, 89);
            DeepPink_Btn.Name = "DeepPink_Btn";
            DeepPink_Btn.Size = new Size(26, 26);
            DeepPink_Btn.TabIndex = 68;
            DeepPink_Btn.UseVisualStyleBackColor = false;
            DeepPink_Btn.Click += SelectColor;
            // 
            // Navy_Btn
            // 
            Navy_Btn.Anchor = AnchorStyles.None;
            Navy_Btn.BackColor = Color.Navy;
            Navy_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Navy_Btn.FlatAppearance.BorderSize = 0;
            Navy_Btn.FlatStyle = FlatStyle.Popup;
            Navy_Btn.Location = new Point(171, 89);
            Navy_Btn.Name = "Navy_Btn";
            Navy_Btn.Size = new Size(26, 26);
            Navy_Btn.TabIndex = 67;
            Navy_Btn.UseVisualStyleBackColor = false;
            Navy_Btn.Click += SelectColor;
            // 
            // Sienna_Btn
            // 
            Sienna_Btn.Anchor = AnchorStyles.None;
            Sienna_Btn.BackColor = Color.Sienna;
            Sienna_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Sienna_Btn.FlatAppearance.BorderSize = 0;
            Sienna_Btn.FlatStyle = FlatStyle.Popup;
            Sienna_Btn.Location = new Point(267, 89);
            Sienna_Btn.Name = "Sienna_Btn";
            Sienna_Btn.Size = new Size(26, 26);
            Sienna_Btn.TabIndex = 66;
            Sienna_Btn.UseVisualStyleBackColor = false;
            Sienna_Btn.Click += SelectColor;
            // 
            // Goldenrod_Btn
            // 
            Goldenrod_Btn.Anchor = AnchorStyles.None;
            Goldenrod_Btn.BackColor = Color.Goldenrod;
            Goldenrod_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Goldenrod_Btn.FlatAppearance.BorderSize = 0;
            Goldenrod_Btn.FlatStyle = FlatStyle.Popup;
            Goldenrod_Btn.Location = new Point(78, 89);
            Goldenrod_Btn.Name = "Goldenrod_Btn";
            Goldenrod_Btn.Size = new Size(26, 26);
            Goldenrod_Btn.TabIndex = 65;
            Goldenrod_Btn.UseVisualStyleBackColor = false;
            Goldenrod_Btn.Click += SelectColor;
            // 
            // Crimson_Btn
            // 
            Crimson_Btn.Anchor = AnchorStyles.None;
            Crimson_Btn.BackColor = Color.Crimson;
            Crimson_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Crimson_Btn.FlatAppearance.BorderSize = 0;
            Crimson_Btn.FlatStyle = FlatStyle.Popup;
            Crimson_Btn.Location = new Point(14, 89);
            Crimson_Btn.Name = "Crimson_Btn";
            Crimson_Btn.Size = new Size(26, 26);
            Crimson_Btn.TabIndex = 63;
            Crimson_Btn.UseVisualStyleBackColor = false;
            Crimson_Btn.Click += SelectColor;
            // 
            // DarkGreen_Btn
            // 
            DarkGreen_Btn.Anchor = AnchorStyles.None;
            DarkGreen_Btn.BackColor = Color.DarkGreen;
            DarkGreen_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DarkGreen_Btn.FlatAppearance.BorderSize = 0;
            DarkGreen_Btn.FlatStyle = FlatStyle.Popup;
            DarkGreen_Btn.Location = new Point(109, 89);
            DarkGreen_Btn.Name = "DarkGreen_Btn";
            DarkGreen_Btn.Size = new Size(26, 26);
            DarkGreen_Btn.TabIndex = 64;
            DarkGreen_Btn.UseVisualStyleBackColor = false;
            DarkGreen_Btn.Click += SelectColor;
            // 
            // Tomato_Btn
            // 
            Tomato_Btn.Anchor = AnchorStyles.None;
            Tomato_Btn.BackColor = Color.Tomato;
            Tomato_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Tomato_Btn.FlatAppearance.BorderSize = 0;
            Tomato_Btn.FlatStyle = FlatStyle.Popup;
            Tomato_Btn.Location = new Point(78, 27);
            Tomato_Btn.Name = "Tomato_Btn";
            Tomato_Btn.Size = new Size(26, 26);
            Tomato_Btn.TabIndex = 61;
            Tomato_Btn.UseVisualStyleBackColor = false;
            Tomato_Btn.Click += SelectColor;
            // 
            // DarkOrange_Btn
            // 
            DarkOrange_Btn.Anchor = AnchorStyles.None;
            DarkOrange_Btn.BackColor = Color.DarkOrange;
            DarkOrange_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DarkOrange_Btn.FlatAppearance.BorderSize = 0;
            DarkOrange_Btn.FlatStyle = FlatStyle.Popup;
            DarkOrange_Btn.Location = new Point(78, 57);
            DarkOrange_Btn.Name = "DarkOrange_Btn";
            DarkOrange_Btn.Size = new Size(26, 26);
            DarkOrange_Btn.TabIndex = 62;
            DarkOrange_Btn.UseVisualStyleBackColor = false;
            DarkOrange_Btn.Click += SelectColor;
            // 
            // SteelBlue_Btn
            // 
            SteelBlue_Btn.Anchor = AnchorStyles.None;
            SteelBlue_Btn.BackColor = Color.SteelBlue;
            SteelBlue_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            SteelBlue_Btn.FlatAppearance.BorderSize = 0;
            SteelBlue_Btn.FlatStyle = FlatStyle.Popup;
            SteelBlue_Btn.Location = new Point(139, 89);
            SteelBlue_Btn.Name = "SteelBlue_Btn";
            SteelBlue_Btn.Size = new Size(26, 26);
            SteelBlue_Btn.TabIndex = 60;
            SteelBlue_Btn.UseVisualStyleBackColor = false;
            SteelBlue_Btn.Click += SelectColor;
            // 
            // LightGray_Btn
            // 
            LightGray_Btn.Anchor = AnchorStyles.None;
            LightGray_Btn.BackColor = Color.LightGray;
            LightGray_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            LightGray_Btn.FlatAppearance.BorderSize = 0;
            LightGray_Btn.FlatStyle = FlatStyle.Popup;
            LightGray_Btn.Location = new Point(46, 27);
            LightGray_Btn.Name = "LightGray_Btn";
            LightGray_Btn.Size = new Size(26, 26);
            LightGray_Btn.TabIndex = 59;
            LightGray_Btn.UseVisualStyleBackColor = false;
            LightGray_Btn.Click += SelectColor;
            // 
            // Purple_Btn
            // 
            Purple_Btn.Anchor = AnchorStyles.None;
            Purple_Btn.BackColor = Color.Purple;
            Purple_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Purple_Btn.FlatAppearance.BorderSize = 0;
            Purple_Btn.FlatStyle = FlatStyle.Popup;
            Purple_Btn.Location = new Point(203, 89);
            Purple_Btn.Name = "Purple_Btn";
            Purple_Btn.Size = new Size(26, 26);
            Purple_Btn.TabIndex = 58;
            Purple_Btn.UseVisualStyleBackColor = false;
            Purple_Btn.Click += SelectColor;
            // 
            // Blue_Btn
            // 
            Blue_Btn.Anchor = AnchorStyles.None;
            Blue_Btn.BackColor = Color.Blue;
            Blue_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Blue_Btn.FlatAppearance.BorderSize = 0;
            Blue_Btn.FlatStyle = FlatStyle.Popup;
            Blue_Btn.Location = new Point(203, 57);
            Blue_Btn.Name = "Blue_Btn";
            Blue_Btn.Size = new Size(26, 26);
            Blue_Btn.TabIndex = 57;
            Blue_Btn.UseVisualStyleBackColor = false;
            Blue_Btn.Click += SelectColor;
            // 
            // CurrentColorHTML
            // 
            CurrentColorHTML.Anchor = AnchorStyles.None;
            CurrentColorHTML.BackColor = Color.WhiteSmoke;
            CurrentColorHTML.BorderStyle = BorderStyle.FixedSingle;
            CurrentColorHTML.Font = new Font("Calibri", 12F);
            CurrentColorHTML.ForeColor = Color.Black;
            CurrentColorHTML.Location = new Point(417, 6);
            CurrentColorHTML.Name = "CurrentColorHTML";
            CurrentColorHTML.Size = new Size(115, 27);
            CurrentColorHTML.TabIndex = 50;
            CurrentColorHTML.TextAlign = HorizontalAlignment.Center;
            CurrentColorHTML.KeyPress += ColorHTMLChanged;
            // 
            // HotPink_Btn
            // 
            HotPink_Btn.Anchor = AnchorStyles.None;
            HotPink_Btn.BackColor = Color.HotPink;
            HotPink_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            HotPink_Btn.FlatAppearance.BorderSize = 0;
            HotPink_Btn.FlatStyle = FlatStyle.Popup;
            HotPink_Btn.Location = new Point(267, 57);
            HotPink_Btn.Name = "HotPink_Btn";
            HotPink_Btn.Size = new Size(26, 26);
            HotPink_Btn.TabIndex = 15;
            HotPink_Btn.UseVisualStyleBackColor = false;
            HotPink_Btn.Click += SelectColor;
            // 
            // ColorSlider_R
            // 
            ColorSlider_R.Anchor = AnchorStyles.None;
            ColorSlider_R.AutoSize = false;
            ColorSlider_R.BackColor = Color.WhiteSmoke;
            ColorSlider_R.Location = new Point(344, 41);
            ColorSlider_R.Maximum = 255;
            ColorSlider_R.Name = "ColorSlider_R";
            ColorSlider_R.Size = new Size(145, 27);
            ColorSlider_R.TabIndex = 47;
            ColorSlider_R.TickStyle = TickStyle.None;
            ColorSlider_R.Scroll += ColorSliderChanged;
            // 
            // Orange_Btn
            // 
            Orange_Btn.Anchor = AnchorStyles.None;
            Orange_Btn.BackColor = Color.Orange;
            Orange_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Orange_Btn.FlatAppearance.BorderSize = 0;
            Orange_Btn.FlatStyle = FlatStyle.Popup;
            Orange_Btn.Location = new Point(109, 27);
            Orange_Btn.Name = "Orange_Btn";
            Orange_Btn.Size = new Size(26, 26);
            Orange_Btn.TabIndex = 14;
            Orange_Btn.UseVisualStyleBackColor = false;
            Orange_Btn.Click += SelectColor;
            // 
            // CurrentColor_B
            // 
            CurrentColor_B.Anchor = AnchorStyles.None;
            CurrentColor_B.BackColor = Color.WhiteSmoke;
            CurrentColor_B.BorderStyle = BorderStyle.FixedSingle;
            CurrentColor_B.Font = new Font("Calibri", 12F);
            CurrentColor_B.ForeColor = Color.Black;
            CurrentColor_B.Location = new Point(495, 99);
            CurrentColor_B.Name = "CurrentColor_B";
            CurrentColor_B.Size = new Size(37, 27);
            CurrentColor_B.TabIndex = 56;
            CurrentColor_B.TextAlign = HorizontalAlignment.Center;
            CurrentColor_B.KeyPress += RGBTextboxChanged;
            // 
            // BlueViolet_Btn
            // 
            BlueViolet_Btn.Anchor = AnchorStyles.None;
            BlueViolet_Btn.BackColor = Color.BlueViolet;
            BlueViolet_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            BlueViolet_Btn.FlatAppearance.BorderSize = 0;
            BlueViolet_Btn.FlatStyle = FlatStyle.Popup;
            BlueViolet_Btn.Location = new Point(235, 57);
            BlueViolet_Btn.Name = "BlueViolet_Btn";
            BlueViolet_Btn.Size = new Size(26, 26);
            BlueViolet_Btn.TabIndex = 11;
            BlueViolet_Btn.UseVisualStyleBackColor = false;
            BlueViolet_Btn.Click += SelectColor;
            // 
            // ColorSlider_G
            // 
            ColorSlider_G.Anchor = AnchorStyles.None;
            ColorSlider_G.AutoSize = false;
            ColorSlider_G.BackColor = Color.WhiteSmoke;
            ColorSlider_G.Location = new Point(344, 72);
            ColorSlider_G.Maximum = 255;
            ColorSlider_G.Name = "ColorSlider_G";
            ColorSlider_G.Size = new Size(145, 27);
            ColorSlider_G.TabIndex = 48;
            ColorSlider_G.TickStyle = TickStyle.None;
            ColorSlider_G.Scroll += ColorSliderChanged;
            // 
            // LimeGreen_Btn
            // 
            LimeGreen_Btn.Anchor = AnchorStyles.None;
            LimeGreen_Btn.BackColor = Color.LimeGreen;
            LimeGreen_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            LimeGreen_Btn.FlatAppearance.BorderSize = 0;
            LimeGreen_Btn.FlatStyle = FlatStyle.Popup;
            LimeGreen_Btn.Location = new Point(139, 57);
            LimeGreen_Btn.Name = "LimeGreen_Btn";
            LimeGreen_Btn.Size = new Size(26, 26);
            LimeGreen_Btn.TabIndex = 13;
            LimeGreen_Btn.UseVisualStyleBackColor = false;
            LimeGreen_Btn.Click += SelectColor;
            // 
            // CurrentColor_G
            // 
            CurrentColor_G.Anchor = AnchorStyles.None;
            CurrentColor_G.BackColor = Color.WhiteSmoke;
            CurrentColor_G.BorderStyle = BorderStyle.FixedSingle;
            CurrentColor_G.Font = new Font("Calibri", 12F);
            CurrentColor_G.ForeColor = Color.Black;
            CurrentColor_G.Location = new Point(495, 68);
            CurrentColor_G.Name = "CurrentColor_G";
            CurrentColor_G.Size = new Size(37, 27);
            CurrentColor_G.TabIndex = 55;
            CurrentColor_G.TextAlign = HorizontalAlignment.Center;
            CurrentColor_G.KeyPress += RGBTextboxChanged;
            // 
            // DeepSkyBlue_Btn
            // 
            DeepSkyBlue_Btn.Anchor = AnchorStyles.None;
            DeepSkyBlue_Btn.BackColor = Color.DeepSkyBlue;
            DeepSkyBlue_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DeepSkyBlue_Btn.FlatAppearance.BorderSize = 0;
            DeepSkyBlue_Btn.FlatStyle = FlatStyle.Popup;
            DeepSkyBlue_Btn.Location = new Point(171, 57);
            DeepSkyBlue_Btn.Name = "DeepSkyBlue_Btn";
            DeepSkyBlue_Btn.Size = new Size(26, 26);
            DeepSkyBlue_Btn.TabIndex = 9;
            DeepSkyBlue_Btn.UseVisualStyleBackColor = false;
            DeepSkyBlue_Btn.Click += SelectColor;
            // 
            // ColorSlider_B
            // 
            ColorSlider_B.Anchor = AnchorStyles.None;
            ColorSlider_B.AutoSize = false;
            ColorSlider_B.BackColor = Color.WhiteSmoke;
            ColorSlider_B.Location = new Point(344, 103);
            ColorSlider_B.Maximum = 255;
            ColorSlider_B.Name = "ColorSlider_B";
            ColorSlider_B.Size = new Size(145, 27);
            ColorSlider_B.TabIndex = 49;
            ColorSlider_B.TickStyle = TickStyle.None;
            ColorSlider_B.Scroll += ColorSliderChanged;
            // 
            // Fuchsia_Btn
            // 
            Fuchsia_Btn.Anchor = AnchorStyles.None;
            Fuchsia_Btn.BackColor = Color.Fuchsia;
            Fuchsia_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Fuchsia_Btn.FlatAppearance.BorderSize = 0;
            Fuchsia_Btn.FlatStyle = FlatStyle.Popup;
            Fuchsia_Btn.Location = new Point(267, 27);
            Fuchsia_Btn.Name = "Fuchsia_Btn";
            Fuchsia_Btn.Size = new Size(26, 26);
            Fuchsia_Btn.TabIndex = 7;
            Fuchsia_Btn.UseVisualStyleBackColor = false;
            Fuchsia_Btn.Click += SelectColor;
            // 
            // CurrentColor_R
            // 
            CurrentColor_R.Anchor = AnchorStyles.None;
            CurrentColor_R.BackColor = Color.WhiteSmoke;
            CurrentColor_R.BorderStyle = BorderStyle.FixedSingle;
            CurrentColor_R.Font = new Font("Calibri", 12F);
            CurrentColor_R.ForeColor = Color.Black;
            CurrentColor_R.Location = new Point(495, 37);
            CurrentColor_R.Name = "CurrentColor_R";
            CurrentColor_R.Size = new Size(37, 27);
            CurrentColor_R.TabIndex = 54;
            CurrentColor_R.TextAlign = HorizontalAlignment.Center;
            CurrentColor_R.KeyPress += RGBTextboxChanged;
            // 
            // RoyalBlue_Btn
            // 
            RoyalBlue_Btn.Anchor = AnchorStyles.None;
            RoyalBlue_Btn.BackColor = Color.RoyalBlue;
            RoyalBlue_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RoyalBlue_Btn.FlatAppearance.BorderSize = 0;
            RoyalBlue_Btn.FlatStyle = FlatStyle.Popup;
            RoyalBlue_Btn.Location = new Point(235, 27);
            RoyalBlue_Btn.Name = "RoyalBlue_Btn";
            RoyalBlue_Btn.Size = new Size(26, 26);
            RoyalBlue_Btn.TabIndex = 6;
            RoyalBlue_Btn.UseVisualStyleBackColor = false;
            RoyalBlue_Btn.Click += SelectColor;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(324, 41);
            label6.Name = "label6";
            label6.Size = new Size(18, 19);
            label6.TabIndex = 51;
            label6.Text = "R";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Gray_Btn
            // 
            Gray_Btn.Anchor = AnchorStyles.None;
            Gray_Btn.BackColor = Color.Gray;
            Gray_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Gray_Btn.FlatAppearance.BorderSize = 0;
            Gray_Btn.FlatStyle = FlatStyle.Popup;
            Gray_Btn.Location = new Point(14, 57);
            Gray_Btn.Name = "Gray_Btn";
            Gray_Btn.Size = new Size(26, 26);
            Gray_Btn.TabIndex = 10;
            Gray_Btn.UseVisualStyleBackColor = false;
            Gray_Btn.Click += SelectColor;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(324, 104);
            label8.Name = "label8";
            label8.Size = new Size(18, 19);
            label8.TabIndex = 53;
            label8.Text = "B";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Gold_Btn
            // 
            Gold_Btn.Anchor = AnchorStyles.None;
            Gold_Btn.BackColor = Color.Gold;
            Gold_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Gold_Btn.FlatAppearance.BorderSize = 0;
            Gold_Btn.FlatStyle = FlatStyle.Popup;
            Gold_Btn.Location = new Point(109, 57);
            Gold_Btn.Name = "Gold_Btn";
            Gold_Btn.Size = new Size(26, 26);
            Gold_Btn.TabIndex = 8;
            Gold_Btn.UseVisualStyleBackColor = false;
            Gold_Btn.Click += SelectColor;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(324, 73);
            label7.Name = "label7";
            label7.Size = new Size(19, 19);
            label7.TabIndex = 52;
            label7.Text = "G";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LawnGreen_Btn
            // 
            LawnGreen_Btn.Anchor = AnchorStyles.None;
            LawnGreen_Btn.BackColor = Color.LawnGreen;
            LawnGreen_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            LawnGreen_Btn.FlatAppearance.BorderSize = 0;
            LawnGreen_Btn.FlatStyle = FlatStyle.Popup;
            LawnGreen_Btn.Location = new Point(171, 27);
            LawnGreen_Btn.Name = "LawnGreen_Btn";
            LawnGreen_Btn.Size = new Size(26, 26);
            LawnGreen_Btn.TabIndex = 4;
            LawnGreen_Btn.UseVisualStyleBackColor = false;
            LawnGreen_Btn.Click += SelectColor;
            // 
            // Chocolate_Btn
            // 
            Chocolate_Btn.Anchor = AnchorStyles.None;
            Chocolate_Btn.BackColor = Color.Chocolate;
            Chocolate_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Chocolate_Btn.FlatAppearance.BorderSize = 0;
            Chocolate_Btn.FlatStyle = FlatStyle.Popup;
            Chocolate_Btn.Location = new Point(46, 89);
            Chocolate_Btn.Name = "Chocolate_Btn";
            Chocolate_Btn.Size = new Size(26, 26);
            Chocolate_Btn.TabIndex = 2;
            Chocolate_Btn.UseVisualStyleBackColor = false;
            Chocolate_Btn.Click += SelectColor;
            // 
            // Red_Btn
            // 
            Red_Btn.Anchor = AnchorStyles.None;
            Red_Btn.BackColor = Color.Red;
            Red_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Red_Btn.FlatAppearance.BorderSize = 0;
            Red_Btn.FlatStyle = FlatStyle.Popup;
            Red_Btn.Location = new Point(46, 57);
            Red_Btn.Name = "Red_Btn";
            Red_Btn.Size = new Size(26, 26);
            Red_Btn.TabIndex = 1;
            Red_Btn.UseVisualStyleBackColor = false;
            Red_Btn.Click += SelectColor;
            // 
            // Yellow_Btn
            // 
            Yellow_Btn.Anchor = AnchorStyles.None;
            Yellow_Btn.BackColor = Color.Yellow;
            Yellow_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Yellow_Btn.FlatAppearance.BorderSize = 0;
            Yellow_Btn.FlatStyle = FlatStyle.Popup;
            Yellow_Btn.Location = new Point(139, 27);
            Yellow_Btn.Name = "Yellow_Btn";
            Yellow_Btn.Size = new Size(26, 26);
            Yellow_Btn.TabIndex = 3;
            Yellow_Btn.UseVisualStyleBackColor = false;
            Yellow_Btn.Click += SelectColor;
            // 
            // Black_Btn
            // 
            Black_Btn.Anchor = AnchorStyles.None;
            Black_Btn.BackColor = Color.Black;
            Black_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Black_Btn.FlatAppearance.BorderSize = 0;
            Black_Btn.FlatStyle = FlatStyle.Popup;
            Black_Btn.Location = new Point(14, 27);
            Black_Btn.Name = "Black_Btn";
            Black_Btn.Size = new Size(26, 26);
            Black_Btn.TabIndex = 0;
            Black_Btn.UseVisualStyleBackColor = false;
            Black_Btn.Click += SelectColor;
            // 
            // Cyan_Btn
            // 
            Cyan_Btn.Anchor = AnchorStyles.None;
            Cyan_Btn.BackColor = Color.Cyan;
            Cyan_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Cyan_Btn.FlatAppearance.BorderSize = 0;
            Cyan_Btn.FlatStyle = FlatStyle.Popup;
            Cyan_Btn.Location = new Point(203, 27);
            Cyan_Btn.Name = "Cyan_Btn";
            Cyan_Btn.Size = new Size(26, 26);
            Cyan_Btn.TabIndex = 5;
            Cyan_Btn.UseVisualStyleBackColor = false;
            Cyan_Btn.Click += SelectColor;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(Settings_Btn);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1634, 150);
            panel1.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(ExportImageButton);
            panel3.Controls.Add(NewImageButton);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(ClearImageButton);
            panel3.Controls.Add(ImportImageButton);
            panel3.Location = new Point(898, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 150);
            panel3.TabIndex = 66;
            // 
            // ExportImageButton
            // 
            ExportImageButton.BackColor = Color.White;
            ExportImageButton.BorderRadius = 16;
            ExportImageButton.BorderWidth = 0F;
            ExportImageButton.FlatAppearance.BorderSize = 0;
            ExportImageButton.FlatStyle = FlatStyle.Flat;
            ExportImageButton.Font = new Font("Calibri", 12F);
            ExportImageButton.ForeColor = Color.Black;
            ExportImageButton.Location = new Point(195, 74);
            ExportImageButton.Name = "ExportImageButton";
            ExportImageButton.RoundBottomLeft = true;
            ExportImageButton.RoundBottomRight = true;
            ExportImageButton.RoundTopLeft = true;
            ExportImageButton.RoundTopRight = true;
            ExportImageButton.Size = new Size(181, 33);
            ExportImageButton.TabIndex = 62;
            ExportImageButton.Text = "Экспорт изображения";
            ExportImageButton.UseVisualStyleBackColor = false;
            ExportImageButton.Click += ExportImageButton_Click;
            // 
            // NewImageButton
            // 
            NewImageButton.BackColor = Color.White;
            NewImageButton.BorderRadius = 16;
            NewImageButton.BorderWidth = 0F;
            NewImageButton.FlatAppearance.BorderSize = 0;
            NewImageButton.FlatStyle = FlatStyle.Flat;
            NewImageButton.Font = new Font("Calibri", 12F);
            NewImageButton.ForeColor = Color.Black;
            NewImageButton.Location = new Point(5, 34);
            NewImageButton.Name = "NewImageButton";
            NewImageButton.RoundBottomLeft = true;
            NewImageButton.RoundBottomRight = true;
            NewImageButton.RoundTopLeft = true;
            NewImageButton.RoundTopRight = true;
            NewImageButton.Size = new Size(181, 33);
            NewImageButton.TabIndex = 59;
            NewImageButton.Text = "Новое изображение";
            NewImageButton.UseVisualStyleBackColor = false;
            NewImageButton.Click += NewImageButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(122, 123);
            label2.Name = "label2";
            label2.Size = new Size(125, 26);
            label2.TabIndex = 63;
            label2.Text = "Изображение";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClearImageButton
            // 
            ClearImageButton.BackColor = Color.White;
            ClearImageButton.BorderRadius = 16;
            ClearImageButton.BorderWidth = 0F;
            ClearImageButton.FlatAppearance.BorderSize = 0;
            ClearImageButton.FlatStyle = FlatStyle.Flat;
            ClearImageButton.Font = new Font("Calibri", 12F);
            ClearImageButton.ForeColor = Color.Black;
            ClearImageButton.Location = new Point(5, 74);
            ClearImageButton.Name = "ClearImageButton";
            ClearImageButton.RoundBottomLeft = true;
            ClearImageButton.RoundBottomRight = true;
            ClearImageButton.RoundTopLeft = true;
            ClearImageButton.RoundTopRight = true;
            ClearImageButton.Size = new Size(181, 33);
            ClearImageButton.TabIndex = 60;
            ClearImageButton.Text = "Очистить изображение";
            ClearImageButton.UseVisualStyleBackColor = false;
            ClearImageButton.Click += ClearImageButton_Click;
            // 
            // ImportImageButton
            // 
            ImportImageButton.BackColor = Color.White;
            ImportImageButton.BorderRadius = 16;
            ImportImageButton.BorderWidth = 0F;
            ImportImageButton.FlatAppearance.BorderSize = 0;
            ImportImageButton.FlatStyle = FlatStyle.Flat;
            ImportImageButton.Font = new Font("Calibri", 12F);
            ImportImageButton.ForeColor = Color.Black;
            ImportImageButton.Location = new Point(195, 34);
            ImportImageButton.Name = "ImportImageButton";
            ImportImageButton.RoundBottomLeft = true;
            ImportImageButton.RoundBottomRight = true;
            ImportImageButton.RoundTopLeft = true;
            ImportImageButton.RoundTopRight = true;
            ImportImageButton.Size = new Size(181, 33);
            ImportImageButton.TabIndex = 61;
            ImportImageButton.Text = "Импорт изображения";
            ImportImageButton.UseVisualStyleBackColor = false;
            ImportImageButton.Click += ImportImageButton_Click;
            // 
            // Settings_Btn
            // 
            Settings_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Settings_Btn.BackColor = Color.Transparent;
            Settings_Btn.BackgroundImage = Resources.settings;
            Settings_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Settings_Btn.BorderRadius = 4;
            Settings_Btn.BorderWidth = 0F;
            Settings_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Settings_Btn.FlatAppearance.BorderSize = 0;
            Settings_Btn.FlatStyle = FlatStyle.Flat;
            Settings_Btn.ForeColor = Color.Black;
            Settings_Btn.Location = new Point(1587, 12);
            Settings_Btn.Name = "Settings_Btn";
            Settings_Btn.RoundBottomLeft = true;
            Settings_Btn.RoundBottomRight = true;
            Settings_Btn.RoundTopLeft = true;
            Settings_Btn.RoundTopRight = true;
            Settings_Btn.Size = new Size(35, 35);
            Settings_Btn.TabIndex = 65;
            Settings_Btn.UseVisualStyleBackColor = false;
            Settings_Btn.Click += SettingsButton_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Left;
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(rotatableLineControl2);
            panel6.Controls.Add(Hexagon_Btn);
            panel6.Controls.Add(Rhombus_Btn);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(StarEight_Btn);
            panel6.Controls.Add(RightTriangle_Btn);
            panel6.Controls.Add(StarSix_Btn);
            panel6.Controls.Add(Rectangle_Btn);
            panel6.Controls.Add(StarFive_Btn);
            panel6.Controls.Add(Circle_Btn);
            panel6.Controls.Add(RegularTriangle_Btn);
            panel6.Controls.Add(Line_Btn);
            panel6.Location = new Point(3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(223, 150);
            panel6.TabIndex = 58;
            // 
            // rotatableLineControl2
            // 
            rotatableLineControl2.Color = Color.Black;
            rotatableLineControl2.LineWidth = 2F;
            rotatableLineControl2.Location = new Point(213, 0);
            rotatableLineControl2.Name = "rotatableLineControl2";
            rotatableLineControl2.RotationAngle = 0F;
            rotatableLineControl2.Size = new Size(10, 150);
            rotatableLineControl2.TabIndex = 33;
            // 
            // DrawingTimer
            // 
            DrawingTimer.Interval = 5;
            DrawingTimer.Tick += DrawingTimer_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // CoordinatesLabel
            // 
            CoordinatesLabel.BackColor = Color.Transparent;
            CoordinatesLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CoordinatesLabel.Location = new Point(3, 5);
            CoordinatesLabel.Name = "CoordinatesLabel";
            CoordinatesLabel.Size = new Size(135, 21);
            CoordinatesLabel.TabIndex = 44;
            CoordinatesLabel.Text = "0, 0пкс";
            CoordinatesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SizeLabel
            // 
            SizeLabel.BackColor = Color.Transparent;
            SizeLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SizeLabel.Location = new Point(144, 5);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(152, 21);
            SizeLabel.TabIndex = 48;
            SizeLabel.Text = "Нет изображения";
            SizeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = Color.WhiteSmoke;
            roundPanel1.BorderRadius = 13;
            roundPanel1.Controls.Add(PenWidthLabel);
            roundPanel1.Controls.Add(Scribble);
            roundPanel1.Controls.Add(PenTrackBar);
            roundPanel1.ForeColor = Color.Black;
            roundPanel1.Location = new Point(10, 290);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.RoundBottomLeft = true;
            roundPanel1.RoundBottomRight = true;
            roundPanel1.RoundTopLeft = true;
            roundPanel1.RoundTopRight = true;
            roundPanel1.Size = new Size(50, 480);
            roundPanel1.TabIndex = 50;
            // 
            // PenWidthLabel
            // 
            PenWidthLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PenWidthLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PenWidthLabel.Location = new Point(4, 15);
            PenWidthLabel.Name = "PenWidthLabel";
            PenWidthLabel.Size = new Size(43, 23);
            PenWidthLabel.TabIndex = 49;
            PenWidthLabel.Text = "0";
            PenWidthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Scribble
            // 
            Scribble.BackColor = Color.Transparent;
            Scribble.BackgroundImage = Resources.scribble;
            Scribble.BackgroundImageLayout = ImageLayout.Zoom;
            Scribble.Location = new Point(7, 438);
            Scribble.Name = "Scribble";
            Scribble.Size = new Size(36, 36);
            Scribble.TabIndex = 48;
            Scribble.TabStop = false;
            // 
            // PenTrackBar
            // 
            PenTrackBar.Anchor = AnchorStyles.None;
            PenTrackBar.AutoSize = false;
            PenTrackBar.Location = new Point(15, 37);
            PenTrackBar.Maximum = 99;
            PenTrackBar.Name = "PenTrackBar";
            PenTrackBar.Orientation = Orientation.Vertical;
            PenTrackBar.Size = new Size(27, 407);
            PenTrackBar.TabIndex = 47;
            PenTrackBar.TickStyle = TickStyle.None;
            PenTrackBar.Value = 3;
            PenTrackBar.Scroll += PenTrackBar_Scroll;
            // 
            // roundPanel2
            // 
            roundPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            roundPanel2.BackColor = Color.WhiteSmoke;
            roundPanel2.BorderRadius = 12;
            roundPanel2.Controls.Add(SizeLabel);
            roundPanel2.Controls.Add(CoordinatesLabel);
            roundPanel2.ForeColor = Color.Black;
            roundPanel2.Location = new Point(-2, 882);
            roundPanel2.Name = "roundPanel2";
            roundPanel2.RoundBottomLeft = false;
            roundPanel2.RoundBottomRight = false;
            roundPanel2.RoundTopLeft = false;
            roundPanel2.RoundTopRight = true;
            roundPanel2.Size = new Size(302, 30);
            roundPanel2.TabIndex = 51;
            // 
            // MainImage
            // 
            MainImage.Location = new Point(664, 441);
            MainImage.Name = "MainImage";
            MainImage.Size = new Size(441, 289);
            MainImage.TabIndex = 52;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 205, 205);
            ClientSize = new Size(1634, 909);
            Controls.Add(MainImage);
            Controls.Add(roundPanel2);
            Controls.Add(roundPanel1);
            Controls.Add(panel1);
            Icon = Resources.Icon;
            KeyPreview = true;
            MinimumSize = new Size(1400, 900);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pint v4.3.0";
            KeyDown += MainForm_KeyDown;
            Resize += MainForm_Resize;
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CurrentColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_R).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_B).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            roundPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Scribble).EndInit();
            ((System.ComponentModel.ISupportInitialize)PenTrackBar).EndInit();
            roundPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Label label4;
        private Label label3;
        private TrackBar trackBar1;
        private Label label1;
        private Panel panel2;
        private Button DeepSkyBlue_Btn;
        private Button Gold_Btn;
        private Button Fuchsia_Btn;
        private Button RoyalBlue_Btn;
        private Button Cyan_Btn;
        private Button LawnGreen_Btn;
        private Button Yellow_Btn;
        private Button Chocolate_Btn;
        private Button Red_Btn;
        private Button Black_Btn;
        private Panel panel1;
        private System.Windows.Forms.Timer DrawingTimer;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button BlueViolet_Btn;
        private Button Gray_Btn;
        private TrackBar ColorSlider_B;
        private TrackBar ColorSlider_G;
        private TrackBar ColorSlider_R;
        private Label ColorHTML_Label;
        private TextBox CurrentColor_B;
        private TextBox CurrentColor_G;
        private TextBox CurrentColor_R;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox CurrentColorHTML;
        private Button HotPink_Btn;
        private Button LimeGreen_Btn;
        private Button Orange_Btn;
        private Label CoordinatesLabel;
        private PictureBox Scribble;
        private Panel panel5;
        private Label PenWidthLabel;
        private Panel panel6;
        private Button Blue_Btn;
        private Button LightGray_Btn;
        private Button Purple_Btn;
        private Button DeepPink_Btn;
        private Button Navy_Btn;
        private Button Sienna_Btn;
        private Button Goldenrod_Btn;
        private Button Crimson_Btn;
        private Button DarkGreen_Btn;
        private Button Tomato_Btn;
        private Button DarkOrange_Btn;
        private Button SteelBlue_Btn;
        private Label SizeLabel;
        private RoundPanel roundPanel1;
        private Label label5;
        private PictureBox CurrentColor;
        private TrackBar PenTrackBar;
        private RoundPanel roundPanel2;
        private RoundButton Filler_Btn;
        private RoundButton Pencil_Btn;
        private RoundButton Eraser_Btn;
        private RoundButton RegularTriangle_Btn;
        private RoundButton RightTriangle_Btn;
        private RoundButton Line_Btn;
        private RoundButton Circle_Btn;
        private RoundButton Rectangle_Btn;
        private RoundButton ColorPicker_Btn;
        private RoundButton StarFive_Btn;
        private RoundButton StarEight_Btn;
        private RoundButton StarSix_Btn;
        private RoundButton Rhombus_Btn;
        private RoundButton Hexagon_Btn;
        private LineControl rotatableLineControl1;
        private LineControl rotatableLineControl2;
        private LineControl rotatableLineControl3;
        private RoundButton ExportImageButton;
        private RoundButton ImportImageButton;
        private RoundButton ClearImageButton;
        private RoundButton NewImageButton;
        private Label label2;
        private ScrollablePictureBox MainImage;
        private RoundButton Settings_Btn;
        private Panel panel3;
    }
}
