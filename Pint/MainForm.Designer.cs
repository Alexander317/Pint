﻿namespace Pint
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
            ClearBoard_Btn = new Button();
            SaveFile_Btn = new Button();
            panel4 = new Panel();
            ColorPicker_Btn = new Button();
            Filler_Btn = new Button();
            label4 = new Label();
            Pencil_Btn = new Button();
            Eraser_Btn = new Button();
            label3 = new Label();
            Hexagon_Btn = new Button();
            Rhombus_Btn = new Button();
            StarEight_Btn = new Button();
            StarSix_Btn = new Button();
            StarFive_Btn = new Button();
            RegularTriangle_Btn = new Button();
            RightTriangle_Btn = new Button();
            Line_Btn = new Button();
            Circle_Btn = new Button();
            Rectangle_Btn = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            panel2 = new Panel();
            DeepPink_Btn = new Button();
            Navy_Btn = new Button();
            Sienna_Btn = new Button();
            Goldenrod_Btn = new Button();
            Crimson_Btn = new Button();
            DarkGreen_Btn = new Button();
            OrangeRed_Btn = new Button();
            DarkOrange_Btn = new Button();
            SteelBlue_Btn = new Button();
            LightGray_Btn = new Button();
            Purple_Btn = new Button();
            Blue_Btn = new Button();
            CurrentColorInHTML = new TextBox();
            HotPink_Btn = new Button();
            CurrentColor_Btn = new Button();
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
            SelectFile_Btn = new Button();
            DM_Btn = new Button();
            panel6 = new Panel();
            label2 = new Label();
            MainImage = new PictureBox();
            DrawingTimer = new System.Windows.Forms.Timer(components);
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            CoordinatesLabel = new Label();
            Scribble = new PictureBox();
            panel5 = new Panel();
            PenWidthLabel = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_B).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Scribble).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // ClearBoard_Btn
            // 
            ClearBoard_Btn.Anchor = AnchorStyles.None;
            ClearBoard_Btn.BackColor = Color.Transparent;
            ClearBoard_Btn.FlatAppearance.BorderColor = Color.Black;
            ClearBoard_Btn.FlatAppearance.BorderSize = 0;
            ClearBoard_Btn.FlatStyle = FlatStyle.Popup;
            ClearBoard_Btn.Font = new Font("Calibri", 12F);
            ClearBoard_Btn.Location = new Point(131, 71);
            ClearBoard_Btn.Name = "ClearBoard_Btn";
            ClearBoard_Btn.Size = new Size(141, 78);
            ClearBoard_Btn.TabIndex = 37;
            ClearBoard_Btn.Text = "Очистить";
            ClearBoard_Btn.UseVisualStyleBackColor = false;
            ClearBoard_Btn.Click += ClearBoard_Btn_Click;
            // 
            // SaveFile_Btn
            // 
            SaveFile_Btn.Anchor = AnchorStyles.None;
            SaveFile_Btn.BackColor = Color.Transparent;
            SaveFile_Btn.FlatAppearance.BorderColor = Color.Black;
            SaveFile_Btn.FlatAppearance.BorderSize = 0;
            SaveFile_Btn.FlatStyle = FlatStyle.Popup;
            SaveFile_Btn.Font = new Font("Calibri", 12F);
            SaveFile_Btn.Location = new Point(-1, 71);
            SaveFile_Btn.Name = "SaveFile_Btn";
            SaveFile_Btn.Size = new Size(135, 78);
            SaveFile_Btn.TabIndex = 36;
            SaveFile_Btn.Text = "Сохранить изображение";
            SaveFile_Btn.UseVisualStyleBackColor = false;
            SaveFile_Btn.Click += SaveFile_Btn_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(ColorPicker_Btn);
            panel4.Controls.Add(Filler_Btn);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(Pencil_Btn);
            panel4.Controls.Add(Eraser_Btn);
            panel4.Location = new Point(767, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(143, 150);
            panel4.TabIndex = 33;
            // 
            // ColorPicker_Btn
            // 
            ColorPicker_Btn.Anchor = AnchorStyles.None;
            ColorPicker_Btn.BackgroundImage = Properties.Resources.color_picker;
            ColorPicker_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            ColorPicker_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ColorPicker_Btn.FlatAppearance.BorderSize = 0;
            ColorPicker_Btn.FlatStyle = FlatStyle.Flat;
            ColorPicker_Btn.ForeColor = Color.Black;
            ColorPicker_Btn.Location = new Point(53, 79);
            ColorPicker_Btn.Name = "ColorPicker_Btn";
            ColorPicker_Btn.Size = new Size(32, 32);
            ColorPicker_Btn.TabIndex = 4;
            ColorPicker_Btn.UseVisualStyleBackColor = false;
            ColorPicker_Btn.Click += MainSelect;
            // 
            // Filler_Btn
            // 
            Filler_Btn.Anchor = AnchorStyles.None;
            Filler_Btn.BackgroundImage = Properties.Resources.Filler;
            Filler_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Filler_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Filler_Btn.FlatAppearance.BorderSize = 0;
            Filler_Btn.FlatStyle = FlatStyle.Flat;
            Filler_Btn.ForeColor = Color.Black;
            Filler_Btn.Location = new Point(91, 40);
            Filler_Btn.Name = "Filler_Btn";
            Filler_Btn.Size = new Size(32, 32);
            Filler_Btn.TabIndex = 3;
            Filler_Btn.UseVisualStyleBackColor = false;
            Filler_Btn.Click += MainSelect;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(-3, 120);
            label4.Name = "label4";
            label4.Size = new Size(148, 30);
            label4.TabIndex = 32;
            label4.Text = "Инструменты";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pencil_Btn
            // 
            Pencil_Btn.Anchor = AnchorStyles.None;
            Pencil_Btn.BackgroundImage = Properties.Resources.pencil;
            Pencil_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Pencil_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Pencil_Btn.FlatAppearance.BorderSize = 0;
            Pencil_Btn.FlatStyle = FlatStyle.Flat;
            Pencil_Btn.ForeColor = Color.Black;
            Pencil_Btn.Location = new Point(53, 40);
            Pencil_Btn.Name = "Pencil_Btn";
            Pencil_Btn.Size = new Size(32, 32);
            Pencil_Btn.TabIndex = 2;
            Pencil_Btn.UseVisualStyleBackColor = false;
            Pencil_Btn.Click += MainSelect;
            // 
            // Eraser_Btn
            // 
            Eraser_Btn.Anchor = AnchorStyles.None;
            Eraser_Btn.BackgroundImage = Properties.Resources.eraser;
            Eraser_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Eraser_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Eraser_Btn.FlatAppearance.BorderSize = 0;
            Eraser_Btn.FlatStyle = FlatStyle.Flat;
            Eraser_Btn.ForeColor = Color.Black;
            Eraser_Btn.Location = new Point(15, 40);
            Eraser_Btn.Name = "Eraser_Btn";
            Eraser_Btn.Size = new Size(32, 32);
            Eraser_Btn.TabIndex = 1;
            Eraser_Btn.UseVisualStyleBackColor = false;
            Eraser_Btn.Click += MainSelect;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(37, 120);
            label3.Name = "label3";
            label3.Size = new Size(141, 30);
            label3.TabIndex = 31;
            label3.Text = "Фигуры";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Hexagon_Btn
            // 
            Hexagon_Btn.Anchor = AnchorStyles.None;
            Hexagon_Btn.BackgroundImage = Properties.Resources.hexagon;
            Hexagon_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Hexagon_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Hexagon_Btn.FlatAppearance.BorderSize = 0;
            Hexagon_Btn.FlatStyle = FlatStyle.Flat;
            Hexagon_Btn.ForeColor = Color.Black;
            Hexagon_Btn.Location = new Point(174, 79);
            Hexagon_Btn.Name = "Hexagon_Btn";
            Hexagon_Btn.Size = new Size(32, 32);
            Hexagon_Btn.TabIndex = 10;
            Hexagon_Btn.Tag = "";
            Hexagon_Btn.UseVisualStyleBackColor = false;
            Hexagon_Btn.Click += MainSelect;
            // 
            // Rhombus_Btn
            // 
            Rhombus_Btn.Anchor = AnchorStyles.None;
            Rhombus_Btn.BackgroundImage = Properties.Resources.rhombus;
            Rhombus_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Rhombus_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Rhombus_Btn.FlatAppearance.BorderSize = 0;
            Rhombus_Btn.FlatStyle = FlatStyle.Flat;
            Rhombus_Btn.ForeColor = Color.Black;
            Rhombus_Btn.Location = new Point(133, 79);
            Rhombus_Btn.Name = "Rhombus_Btn";
            Rhombus_Btn.Size = new Size(32, 32);
            Rhombus_Btn.TabIndex = 9;
            Rhombus_Btn.Tag = "";
            Rhombus_Btn.UseVisualStyleBackColor = false;
            Rhombus_Btn.Click += MainSelect;
            // 
            // StarEight_Btn
            // 
            StarEight_Btn.Anchor = AnchorStyles.None;
            StarEight_Btn.BackgroundImage = Properties.Resources.star_eight;
            StarEight_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            StarEight_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            StarEight_Btn.FlatAppearance.BorderSize = 0;
            StarEight_Btn.FlatStyle = FlatStyle.Flat;
            StarEight_Btn.ForeColor = Color.Black;
            StarEight_Btn.Location = new Point(92, 79);
            StarEight_Btn.Name = "StarEight_Btn";
            StarEight_Btn.Size = new Size(32, 32);
            StarEight_Btn.TabIndex = 8;
            StarEight_Btn.Tag = "";
            StarEight_Btn.UseVisualStyleBackColor = false;
            StarEight_Btn.Click += MainSelect;
            // 
            // StarSix_Btn
            // 
            StarSix_Btn.Anchor = AnchorStyles.None;
            StarSix_Btn.BackgroundImage = Properties.Resources.star_six;
            StarSix_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            StarSix_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            StarSix_Btn.FlatAppearance.BorderSize = 0;
            StarSix_Btn.FlatStyle = FlatStyle.Flat;
            StarSix_Btn.ForeColor = Color.Black;
            StarSix_Btn.Location = new Point(51, 79);
            StarSix_Btn.Name = "StarSix_Btn";
            StarSix_Btn.Size = new Size(32, 32);
            StarSix_Btn.TabIndex = 7;
            StarSix_Btn.Tag = "";
            StarSix_Btn.UseVisualStyleBackColor = false;
            StarSix_Btn.Click += MainSelect;
            // 
            // StarFive_Btn
            // 
            StarFive_Btn.Anchor = AnchorStyles.None;
            StarFive_Btn.BackgroundImage = Properties.Resources.star_five;
            StarFive_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            StarFive_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            StarFive_Btn.FlatAppearance.BorderSize = 0;
            StarFive_Btn.FlatStyle = FlatStyle.Flat;
            StarFive_Btn.ForeColor = Color.Black;
            StarFive_Btn.Location = new Point(10, 79);
            StarFive_Btn.Name = "StarFive_Btn";
            StarFive_Btn.Size = new Size(32, 32);
            StarFive_Btn.TabIndex = 6;
            StarFive_Btn.Tag = "";
            StarFive_Btn.UseVisualStyleBackColor = false;
            StarFive_Btn.Click += MainSelect;
            // 
            // RegularTriangle_Btn
            // 
            RegularTriangle_Btn.Anchor = AnchorStyles.None;
            RegularTriangle_Btn.BackgroundImage = Properties.Resources.regular_triangle;
            RegularTriangle_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            RegularTriangle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RegularTriangle_Btn.FlatAppearance.BorderSize = 0;
            RegularTriangle_Btn.FlatStyle = FlatStyle.Flat;
            RegularTriangle_Btn.ForeColor = Color.Black;
            RegularTriangle_Btn.Location = new Point(51, 40);
            RegularTriangle_Btn.Name = "RegularTriangle_Btn";
            RegularTriangle_Btn.Size = new Size(32, 32);
            RegularTriangle_Btn.TabIndex = 5;
            RegularTriangle_Btn.Tag = "";
            RegularTriangle_Btn.UseVisualStyleBackColor = false;
            RegularTriangle_Btn.Click += MainSelect;
            // 
            // RightTriangle_Btn
            // 
            RightTriangle_Btn.Anchor = AnchorStyles.None;
            RightTriangle_Btn.BackgroundImage = Properties.Resources.right_triangle;
            RightTriangle_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            RightTriangle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RightTriangle_Btn.FlatAppearance.BorderSize = 0;
            RightTriangle_Btn.FlatStyle = FlatStyle.Flat;
            RightTriangle_Btn.ForeColor = Color.Black;
            RightTriangle_Btn.Location = new Point(133, 40);
            RightTriangle_Btn.Name = "RightTriangle_Btn";
            RightTriangle_Btn.Size = new Size(32, 32);
            RightTriangle_Btn.TabIndex = 4;
            RightTriangle_Btn.Tag = "";
            RightTriangle_Btn.UseVisualStyleBackColor = false;
            RightTriangle_Btn.Click += MainSelect;
            // 
            // Line_Btn
            // 
            Line_Btn.Anchor = AnchorStyles.None;
            Line_Btn.BackgroundImage = Properties.Resources.line;
            Line_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Line_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Line_Btn.FlatAppearance.BorderSize = 0;
            Line_Btn.FlatStyle = FlatStyle.Flat;
            Line_Btn.ForeColor = Color.Black;
            Line_Btn.Location = new Point(174, 40);
            Line_Btn.Name = "Line_Btn";
            Line_Btn.Size = new Size(32, 32);
            Line_Btn.TabIndex = 3;
            Line_Btn.Tag = "";
            Line_Btn.UseVisualStyleBackColor = false;
            Line_Btn.Click += MainSelect;
            // 
            // Circle_Btn
            // 
            Circle_Btn.Anchor = AnchorStyles.None;
            Circle_Btn.BackgroundImage = Properties.Resources.circle;
            Circle_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Circle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Circle_Btn.FlatAppearance.BorderSize = 0;
            Circle_Btn.FlatStyle = FlatStyle.Flat;
            Circle_Btn.ForeColor = Color.Black;
            Circle_Btn.Location = new Point(10, 40);
            Circle_Btn.Name = "Circle_Btn";
            Circle_Btn.Size = new Size(32, 32);
            Circle_Btn.TabIndex = 2;
            Circle_Btn.Tag = "";
            Circle_Btn.UseVisualStyleBackColor = false;
            Circle_Btn.Click += MainSelect;
            // 
            // Rectangle_Btn
            // 
            Rectangle_Btn.Anchor = AnchorStyles.None;
            Rectangle_Btn.BackgroundImage = Properties.Resources.rectangle;
            Rectangle_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Rectangle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Rectangle_Btn.FlatAppearance.BorderSize = 0;
            Rectangle_Btn.FlatStyle = FlatStyle.Flat;
            Rectangle_Btn.ForeColor = Color.Black;
            Rectangle_Btn.Location = new Point(92, 40);
            Rectangle_Btn.Name = "Rectangle_Btn";
            Rectangle_Btn.Size = new Size(32, 32);
            Rectangle_Btn.TabIndex = 1;
            Rectangle_Btn.Tag = "";
            Rectangle_Btn.UseVisualStyleBackColor = false;
            Rectangle_Btn.Click += MainSelect;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.None;
            trackBar1.AutoSize = false;
            trackBar1.Location = new Point(11, 44);
            trackBar1.Maximum = 99;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(27, 400);
            trackBar1.TabIndex = 28;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(225, 122);
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
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(DeepPink_Btn);
            panel2.Controls.Add(Navy_Btn);
            panel2.Controls.Add(Sienna_Btn);
            panel2.Controls.Add(Goldenrod_Btn);
            panel2.Controls.Add(Crimson_Btn);
            panel2.Controls.Add(DarkGreen_Btn);
            panel2.Controls.Add(OrangeRed_Btn);
            panel2.Controls.Add(DarkOrange_Btn);
            panel2.Controls.Add(SteelBlue_Btn);
            panel2.Controls.Add(LightGray_Btn);
            panel2.Controls.Add(Purple_Btn);
            panel2.Controls.Add(Blue_Btn);
            panel2.Controls.Add(CurrentColorInHTML);
            panel2.Controls.Add(HotPink_Btn);
            panel2.Controls.Add(CurrentColor_Btn);
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
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 150);
            panel2.TabIndex = 25;
            // 
            // DeepPink_Btn
            // 
            DeepPink_Btn.Anchor = AnchorStyles.None;
            DeepPink_Btn.BackColor = Color.DeepPink;
            DeepPink_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DeepPink_Btn.FlatAppearance.BorderSize = 0;
            DeepPink_Btn.FlatStyle = FlatStyle.Popup;
            DeepPink_Btn.Location = new Point(234, 88);
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
            Navy_Btn.Location = new Point(170, 88);
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
            Sienna_Btn.Location = new Point(266, 88);
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
            Goldenrod_Btn.Location = new Point(77, 88);
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
            Crimson_Btn.Location = new Point(13, 88);
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
            DarkGreen_Btn.Location = new Point(108, 88);
            DarkGreen_Btn.Name = "DarkGreen_Btn";
            DarkGreen_Btn.Size = new Size(26, 26);
            DarkGreen_Btn.TabIndex = 64;
            DarkGreen_Btn.UseVisualStyleBackColor = false;
            DarkGreen_Btn.Click += SelectColor;
            // 
            // OrangeRed_Btn
            // 
            OrangeRed_Btn.Anchor = AnchorStyles.None;
            OrangeRed_Btn.BackColor = Color.OrangeRed;
            OrangeRed_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            OrangeRed_Btn.FlatAppearance.BorderSize = 0;
            OrangeRed_Btn.FlatStyle = FlatStyle.Popup;
            OrangeRed_Btn.Location = new Point(45, 56);
            OrangeRed_Btn.Name = "OrangeRed_Btn";
            OrangeRed_Btn.Size = new Size(26, 26);
            OrangeRed_Btn.TabIndex = 61;
            OrangeRed_Btn.UseVisualStyleBackColor = false;
            OrangeRed_Btn.Click += SelectColor;
            // 
            // DarkOrange_Btn
            // 
            DarkOrange_Btn.Anchor = AnchorStyles.None;
            DarkOrange_Btn.BackColor = Color.DarkOrange;
            DarkOrange_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DarkOrange_Btn.FlatAppearance.BorderSize = 0;
            DarkOrange_Btn.FlatStyle = FlatStyle.Popup;
            DarkOrange_Btn.Location = new Point(77, 56);
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
            SteelBlue_Btn.Location = new Point(138, 88);
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
            LightGray_Btn.Location = new Point(45, 26);
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
            Purple_Btn.Location = new Point(202, 88);
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
            Blue_Btn.Location = new Point(202, 56);
            Blue_Btn.Name = "Blue_Btn";
            Blue_Btn.Size = new Size(26, 26);
            Blue_Btn.TabIndex = 57;
            Blue_Btn.UseVisualStyleBackColor = false;
            Blue_Btn.Click += SelectColor;
            // 
            // CurrentColorInHTML
            // 
            CurrentColorInHTML.Anchor = AnchorStyles.None;
            CurrentColorInHTML.BackColor = Color.WhiteSmoke;
            CurrentColorInHTML.BorderStyle = BorderStyle.FixedSingle;
            CurrentColorInHTML.Font = new Font("Calibri", 12F);
            CurrentColorInHTML.ForeColor = Color.Black;
            CurrentColorInHTML.Location = new Point(416, 5);
            CurrentColorInHTML.Name = "CurrentColorInHTML";
            CurrentColorInHTML.Size = new Size(115, 27);
            CurrentColorInHTML.TabIndex = 50;
            CurrentColorInHTML.TextAlign = HorizontalAlignment.Center;
            CurrentColorInHTML.KeyPress += ColorInHTML_KeyPress;
            // 
            // HotPink_Btn
            // 
            HotPink_Btn.Anchor = AnchorStyles.None;
            HotPink_Btn.BackColor = Color.HotPink;
            HotPink_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            HotPink_Btn.FlatAppearance.BorderSize = 0;
            HotPink_Btn.FlatStyle = FlatStyle.Popup;
            HotPink_Btn.Location = new Point(266, 56);
            HotPink_Btn.Name = "HotPink_Btn";
            HotPink_Btn.Size = new Size(26, 26);
            HotPink_Btn.TabIndex = 15;
            HotPink_Btn.UseVisualStyleBackColor = false;
            HotPink_Btn.Click += SelectColor;
            // 
            // CurrentColor_Btn
            // 
            CurrentColor_Btn.Anchor = AnchorStyles.None;
            CurrentColor_Btn.BackColor = Color.Fuchsia;
            CurrentColor_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            CurrentColor_Btn.FlatAppearance.BorderSize = 0;
            CurrentColor_Btn.FlatStyle = FlatStyle.Popup;
            CurrentColor_Btn.Location = new Point(332, 7);
            CurrentColor_Btn.Name = "CurrentColor_Btn";
            CurrentColor_Btn.Size = new Size(80, 23);
            CurrentColor_Btn.TabIndex = 45;
            CurrentColor_Btn.UseVisualStyleBackColor = false;
            // 
            // ColorSlider_R
            // 
            ColorSlider_R.Anchor = AnchorStyles.None;
            ColorSlider_R.AutoSize = false;
            ColorSlider_R.BackColor = Color.WhiteSmoke;
            ColorSlider_R.Location = new Point(350, 40);
            ColorSlider_R.Maximum = 255;
            ColorSlider_R.Name = "ColorSlider_R";
            ColorSlider_R.Size = new Size(138, 27);
            ColorSlider_R.TabIndex = 47;
            ColorSlider_R.TickStyle = TickStyle.None;
            ColorSlider_R.Scroll += ColorFromChangingSlider;
            // 
            // Orange_Btn
            // 
            Orange_Btn.Anchor = AnchorStyles.None;
            Orange_Btn.BackColor = Color.Orange;
            Orange_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Orange_Btn.FlatAppearance.BorderSize = 0;
            Orange_Btn.FlatStyle = FlatStyle.Popup;
            Orange_Btn.Location = new Point(108, 26);
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
            CurrentColor_B.Location = new Point(494, 98);
            CurrentColor_B.Name = "CurrentColor_B";
            CurrentColor_B.Size = new Size(37, 27);
            CurrentColor_B.TabIndex = 56;
            CurrentColor_B.TextAlign = HorizontalAlignment.Center;
            CurrentColor_B.KeyPress += ColorFromChangingRGBTextboxes;
            // 
            // BlueViolet_Btn
            // 
            BlueViolet_Btn.Anchor = AnchorStyles.None;
            BlueViolet_Btn.BackColor = Color.BlueViolet;
            BlueViolet_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            BlueViolet_Btn.FlatAppearance.BorderSize = 0;
            BlueViolet_Btn.FlatStyle = FlatStyle.Popup;
            BlueViolet_Btn.Location = new Point(234, 56);
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
            ColorSlider_G.Location = new Point(350, 71);
            ColorSlider_G.Maximum = 255;
            ColorSlider_G.Name = "ColorSlider_G";
            ColorSlider_G.Size = new Size(138, 27);
            ColorSlider_G.TabIndex = 48;
            ColorSlider_G.TickStyle = TickStyle.None;
            ColorSlider_G.Scroll += ColorFromChangingSlider;
            // 
            // LimeGreen_Btn
            // 
            LimeGreen_Btn.Anchor = AnchorStyles.None;
            LimeGreen_Btn.BackColor = Color.LimeGreen;
            LimeGreen_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            LimeGreen_Btn.FlatAppearance.BorderSize = 0;
            LimeGreen_Btn.FlatStyle = FlatStyle.Popup;
            LimeGreen_Btn.Location = new Point(138, 56);
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
            CurrentColor_G.Location = new Point(494, 67);
            CurrentColor_G.Name = "CurrentColor_G";
            CurrentColor_G.Size = new Size(37, 27);
            CurrentColor_G.TabIndex = 55;
            CurrentColor_G.TextAlign = HorizontalAlignment.Center;
            CurrentColor_G.KeyPress += ColorFromChangingRGBTextboxes;
            // 
            // DeepSkyBlue_Btn
            // 
            DeepSkyBlue_Btn.Anchor = AnchorStyles.None;
            DeepSkyBlue_Btn.BackColor = Color.DeepSkyBlue;
            DeepSkyBlue_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DeepSkyBlue_Btn.FlatAppearance.BorderSize = 0;
            DeepSkyBlue_Btn.FlatStyle = FlatStyle.Popup;
            DeepSkyBlue_Btn.Location = new Point(170, 56);
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
            ColorSlider_B.Location = new Point(350, 102);
            ColorSlider_B.Maximum = 255;
            ColorSlider_B.Name = "ColorSlider_B";
            ColorSlider_B.Size = new Size(138, 27);
            ColorSlider_B.TabIndex = 49;
            ColorSlider_B.TickStyle = TickStyle.None;
            ColorSlider_B.Scroll += ColorFromChangingSlider;
            // 
            // Fuchsia_Btn
            // 
            Fuchsia_Btn.Anchor = AnchorStyles.None;
            Fuchsia_Btn.BackColor = Color.Fuchsia;
            Fuchsia_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Fuchsia_Btn.FlatAppearance.BorderSize = 0;
            Fuchsia_Btn.FlatStyle = FlatStyle.Popup;
            Fuchsia_Btn.Location = new Point(266, 26);
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
            CurrentColor_R.Location = new Point(494, 36);
            CurrentColor_R.Name = "CurrentColor_R";
            CurrentColor_R.Size = new Size(37, 27);
            CurrentColor_R.TabIndex = 54;
            CurrentColor_R.TextAlign = HorizontalAlignment.Center;
            CurrentColor_R.KeyPress += ColorFromChangingRGBTextboxes;
            // 
            // RoyalBlue_Btn
            // 
            RoyalBlue_Btn.Anchor = AnchorStyles.None;
            RoyalBlue_Btn.BackColor = Color.RoyalBlue;
            RoyalBlue_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RoyalBlue_Btn.FlatAppearance.BorderSize = 0;
            RoyalBlue_Btn.FlatStyle = FlatStyle.Popup;
            RoyalBlue_Btn.Location = new Point(234, 26);
            RoyalBlue_Btn.Name = "RoyalBlue_Btn";
            RoyalBlue_Btn.Size = new Size(26, 26);
            RoyalBlue_Btn.TabIndex = 6;
            RoyalBlue_Btn.UseVisualStyleBackColor = false;
            RoyalBlue_Btn.Click += SelectColor;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(332, 35);
            label6.Name = "label6";
            label6.Size = new Size(21, 28);
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
            Gray_Btn.Location = new Point(13, 56);
            Gray_Btn.Name = "Gray_Btn";
            Gray_Btn.Size = new Size(26, 26);
            Gray_Btn.TabIndex = 10;
            Gray_Btn.UseVisualStyleBackColor = false;
            Gray_Btn.Click += SelectColor;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(332, 98);
            label8.Name = "label8";
            label8.Size = new Size(21, 27);
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
            Gold_Btn.Location = new Point(108, 56);
            Gold_Btn.Name = "Gold_Btn";
            Gold_Btn.Size = new Size(26, 26);
            Gold_Btn.TabIndex = 8;
            Gold_Btn.UseVisualStyleBackColor = false;
            Gold_Btn.Click += SelectColor;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(332, 67);
            label7.Name = "label7";
            label7.Size = new Size(21, 27);
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
            LawnGreen_Btn.Location = new Point(170, 26);
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
            Chocolate_Btn.Location = new Point(45, 88);
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
            Red_Btn.Location = new Point(77, 26);
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
            Yellow_Btn.Location = new Point(138, 26);
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
            Black_Btn.Location = new Point(13, 26);
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
            Cyan_Btn.Location = new Point(202, 26);
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
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1626, 150);
            panel1.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(ClearBoard_Btn);
            panel3.Controls.Add(SelectFile_Btn);
            panel3.Controls.Add(SaveFile_Btn);
            panel3.Controls.Add(DM_Btn);
            panel3.Location = new Point(909, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 150);
            panel3.TabIndex = 59;
            // 
            // SelectFile_Btn
            // 
            SelectFile_Btn.Anchor = AnchorStyles.None;
            SelectFile_Btn.BackColor = Color.Transparent;
            SelectFile_Btn.FlatAppearance.BorderColor = Color.Black;
            SelectFile_Btn.FlatAppearance.BorderSize = 0;
            SelectFile_Btn.FlatStyle = FlatStyle.Popup;
            SelectFile_Btn.Font = new Font("Calibri", 12F);
            SelectFile_Btn.Location = new Point(131, -1);
            SelectFile_Btn.Name = "SelectFile_Btn";
            SelectFile_Btn.Size = new Size(141, 74);
            SelectFile_Btn.TabIndex = 42;
            SelectFile_Btn.Text = "Выбрать изображение";
            SelectFile_Btn.UseVisualStyleBackColor = false;
            SelectFile_Btn.Click += SelectFile_Btn_Click;
            // 
            // DM_Btn
            // 
            DM_Btn.Anchor = AnchorStyles.None;
            DM_Btn.BackColor = Color.Transparent;
            DM_Btn.FlatAppearance.BorderSize = 0;
            DM_Btn.FlatStyle = FlatStyle.Popup;
            DM_Btn.Font = new Font("Calibri", 12F);
            DM_Btn.Location = new Point(-1, -1);
            DM_Btn.Name = "DM_Btn";
            DM_Btn.Size = new Size(135, 74);
            DM_Btn.TabIndex = 57;
            DM_Btn.Text = "Тёмная тема: Выкл";
            DM_Btn.UseVisualStyleBackColor = false;
            DM_Btn.Click += DM_Btn_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Left;
            panel6.BackColor = Color.Transparent;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(Hexagon_Btn);
            panel6.Controls.Add(label2);
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
            panel6.Location = new Point(549, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(219, 150);
            panel6.TabIndex = 58;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(37, 178);
            label2.Name = "label2";
            label2.Size = new Size(128, 26);
            label2.TabIndex = 26;
            label2.Text = "Палитра";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainImage
            // 
            MainImage.Anchor = AnchorStyles.None;
            MainImage.BackColor = Color.White;
            MainImage.Location = new Point(68, 199);
            MainImage.Name = "MainImage";
            MainImage.Size = new Size(1480, 680);
            MainImage.TabIndex = 43;
            MainImage.TabStop = false;
            MainImage.Click += MainImage_Click;
            MainImage.MouseDown += MainImage_MouseDown;
            MainImage.MouseMove += MainImage_MouseMove;
            MainImage.MouseUp += MainImage_MouseUp;
            // 
            // DrawingTimer
            // 
            DrawingTimer.Interval = 15;
            DrawingTimer.Tick += DrawingTimer_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // CoordinatesLabel
            // 
            CoordinatesLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CoordinatesLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CoordinatesLabel.Location = new Point(12, 895);
            CoordinatesLabel.Name = "CoordinatesLabel";
            CoordinatesLabel.Size = new Size(114, 23);
            CoordinatesLabel.TabIndex = 44;
            CoordinatesLabel.Text = "0, 0пкс";
            CoordinatesLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Scribble
            // 
            Scribble.BackColor = Color.Transparent;
            Scribble.BackgroundImage = Properties.Resources.scribble;
            Scribble.BackgroundImageLayout = ImageLayout.Stretch;
            Scribble.Location = new Point(4, 441);
            Scribble.Name = "Scribble";
            Scribble.Size = new Size(36, 36);
            Scribble.TabIndex = 45;
            Scribble.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(PenWidthLabel);
            panel5.Controls.Add(Scribble);
            panel5.Controls.Add(trackBar1);
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(5, 316);
            panel5.Name = "panel5";
            panel5.Size = new Size(45, 479);
            panel5.TabIndex = 46;
            // 
            // PenWidthLabel
            // 
            PenWidthLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PenWidthLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PenWidthLabel.Location = new Point(0, 18);
            PenWidthLabel.Name = "PenWidthLabel";
            PenWidthLabel.Size = new Size(43, 23);
            PenWidthLabel.TabIndex = 46;
            PenWidthLabel.Text = "0";
            PenWidthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 175, 175);
            ClientSize = new Size(1626, 927);
            Controls.Add(CoordinatesLabel);
            Controls.Add(panel1);
            Controls.Add(MainImage);
            Controls.Add(panel5);
            Icon = Properties.Resources.Icon;
            KeyPreview = true;
            Name = "MainForm";
            Text = "Pint v4.0.0";
            KeyDown += MainForm_KeyDown;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_R).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_B).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Scribble).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button ClearBoard_Btn;
        private Button SaveFile_Btn;
        private Panel panel4;
        private Button Filler_Btn;
        private Button Pencil_Btn;
        private Button Eraser_Btn;
        private Label label4;
        private Label label3;
        private Button RegularTriangle_Btn;
        private Button RightTriangle_Btn;
        private Button Line_Btn;
        private Button Circle_Btn;
        private Button Rectangle_Btn;
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
        private Button SelectFile_Btn;
        private System.Windows.Forms.Timer DrawingTimer;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button BlueViolet_Btn;
        private Button Gray_Btn;
        private TrackBar ColorSlider_B;
        private TrackBar ColorSlider_G;
        private TrackBar ColorSlider_R;
        private Label ColorHTML_Label;
        private Button CurrentColor_Btn;
        private TextBox CurrentColor_B;
        private TextBox CurrentColor_G;
        private TextBox CurrentColor_R;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox CurrentColorInHTML;
        public PictureBox MainImage;
        private Button HotPink_Btn;
        private Button LimeGreen_Btn;
        private Button Orange_Btn;
        private Button DM_Btn;
        private Label CoordinatesLabel;
        private Button ColorPicker_Btn;
        private PictureBox Scribble;
        private Panel panel5;
        private Label PenWidthLabel;
        private Button StarFive_Btn;
        private Button StarEight_Btn;
        private Button StarSix_Btn;
        private Button Rhombus_Btn;
        private Button Hexagon_Btn;
        private Panel panel6;
        private Label label2;
        private Button Blue_Btn;
        private Button LightGray_Btn;
        private Button Purple_Btn;
        private Button DeepPink_Btn;
        private Button Navy_Btn;
        private Button Sienna_Btn;
        private Button Goldenrod_Btn;
        private Button Crimson_Btn;
        private Button DarkGreen_Btn;
        private Button OrangeRed_Btn;
        private Button DarkOrange_Btn;
        private Button SteelBlue_Btn;
        private Panel panel3;
    }
}