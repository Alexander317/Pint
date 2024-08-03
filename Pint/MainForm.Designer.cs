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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ClearBoard_Btn = new Button();
            SaveFile_Btn = new Button();
            panel4 = new Panel();
            Filler_Btn = new Button();
            Pencil_Btn = new Button();
            Eraser_Btn = new Button();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            RegularTriangle_Btn = new Button();
            RightTriangle_Btn = new Button();
            Line_Btn = new Button();
            Circle_Btn = new Button();
            Rectangle_Btn = new Button();
            label2 = new Label();
            trackBar1 = new TrackBar();
            label1 = new Label();
            panel2 = new Panel();
            Brown_Btn = new Button();
            SlateBlue_Btn = new Button();
            DeepPink_Btn = new Button();
            Aquamarine_Btn = new Button();
            Green_Btn = new Button();
            Fuchsia_Btn = new Button();
            Blue_Btn = new Button();
            Olive_Btn = new Button();
            Purple_Btn = new Button();
            Lime_Btn = new Button();
            Orange_Btn = new Button();
            Red_Btn = new Button();
            Yellow_Btn = new Button();
            Black_Btn = new Button();
            Cyan_Btn = new Button();
            panel1 = new Panel();
            DM_Btn = new Button();
            CurrentColor_B = new TextBox();
            CurrentColor_G = new TextBox();
            CurrentColor_R = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            CurrentColorInHTML = new TextBox();
            ColorSlider_B = new TrackBar();
            ColorSlider_G = new TrackBar();
            ColorSlider_R = new TrackBar();
            CurrentColor_Btn = new Button();
            SelectFile_Btn = new Button();
            MainImage = new PictureBox();
            DrawingTimer = new System.Windows.Forms.Timer(components);
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            CoordinatesLabel = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_G).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainImage).BeginInit();
            SuspendLayout();
            // 
            // ClearBoard_Btn
            // 
            ClearBoard_Btn.Anchor = AnchorStyles.None;
            ClearBoard_Btn.Cursor = Cursors.Hand;
            ClearBoard_Btn.FlatAppearance.BorderColor = Color.Black;
            ClearBoard_Btn.FlatAppearance.BorderSize = 0;
            ClearBoard_Btn.FlatStyle = FlatStyle.Popup;
            ClearBoard_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ClearBoard_Btn.Location = new Point(1307, 126);
            ClearBoard_Btn.Margin = new Padding(3, 2, 3, 2);
            ClearBoard_Btn.Name = "ClearBoard_Btn";
            ClearBoard_Btn.Size = new Size(175, 55);
            ClearBoard_Btn.TabIndex = 37;
            ClearBoard_Btn.Text = "Очистить";
            ClearBoard_Btn.UseVisualStyleBackColor = false;
            ClearBoard_Btn.Click += ClearBoard_Btn_Click;
            // 
            // SaveFile_Btn
            // 
            SaveFile_Btn.Anchor = AnchorStyles.None;
            SaveFile_Btn.Cursor = Cursors.Hand;
            SaveFile_Btn.FlatAppearance.BorderColor = Color.Black;
            SaveFile_Btn.FlatAppearance.BorderSize = 0;
            SaveFile_Btn.FlatStyle = FlatStyle.Popup;
            SaveFile_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SaveFile_Btn.Location = new Point(1307, 10);
            SaveFile_Btn.Margin = new Padding(3, 2, 3, 2);
            SaveFile_Btn.Name = "SaveFile_Btn";
            SaveFile_Btn.Size = new Size(175, 55);
            SaveFile_Btn.TabIndex = 36;
            SaveFile_Btn.Text = "Сохранить изображение";
            SaveFile_Btn.UseVisualStyleBackColor = false;
            SaveFile_Btn.Click += SaveFile_Btn_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(Filler_Btn);
            panel4.Controls.Add(Pencil_Btn);
            panel4.Controls.Add(Eraser_Btn);
            panel4.Location = new Point(1126, 49);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(148, 50);
            panel4.TabIndex = 33;
            // 
            // Filler_Btn
            // 
            Filler_Btn.Anchor = AnchorStyles.None;
            Filler_Btn.BackgroundImage = (Image)resources.GetObject("Filler_Btn.BackgroundImage");
            Filler_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Filler_Btn.Cursor = Cursors.Hand;
            Filler_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Filler_Btn.FlatAppearance.BorderSize = 0;
            Filler_Btn.FlatStyle = FlatStyle.Flat;
            Filler_Btn.ForeColor = Color.Black;
            Filler_Btn.Location = new Point(95, 8);
            Filler_Btn.Margin = new Padding(3, 2, 3, 2);
            Filler_Btn.Name = "Filler_Btn";
            Filler_Btn.Size = new Size(32, 32);
            Filler_Btn.TabIndex = 3;
            Filler_Btn.UseVisualStyleBackColor = false;
            Filler_Btn.Click += MainSelect;
            // 
            // Pencil_Btn
            // 
            Pencil_Btn.Anchor = AnchorStyles.None;
            Pencil_Btn.BackgroundImage = (Image)resources.GetObject("Pencil_Btn.BackgroundImage");
            Pencil_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Pencil_Btn.Cursor = Cursors.Hand;
            Pencil_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Pencil_Btn.FlatAppearance.BorderSize = 0;
            Pencil_Btn.FlatStyle = FlatStyle.Flat;
            Pencil_Btn.ForeColor = Color.Black;
            Pencil_Btn.Location = new Point(55, 8);
            Pencil_Btn.Margin = new Padding(3, 2, 3, 2);
            Pencil_Btn.Name = "Pencil_Btn";
            Pencil_Btn.Size = new Size(32, 32);
            Pencil_Btn.TabIndex = 2;
            Pencil_Btn.UseVisualStyleBackColor = false;
            Pencil_Btn.Click += MainSelect;
            // 
            // Eraser_Btn
            // 
            Eraser_Btn.Anchor = AnchorStyles.None;
            Eraser_Btn.BackgroundImage = (Image)resources.GetObject("Eraser_Btn.BackgroundImage");
            Eraser_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Eraser_Btn.Cursor = Cursors.Hand;
            Eraser_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Eraser_Btn.FlatAppearance.BorderSize = 0;
            Eraser_Btn.FlatStyle = FlatStyle.Flat;
            Eraser_Btn.ForeColor = Color.Black;
            Eraser_Btn.Location = new Point(15, 8);
            Eraser_Btn.Margin = new Padding(3, 2, 3, 2);
            Eraser_Btn.Name = "Eraser_Btn";
            Eraser_Btn.Size = new Size(32, 32);
            Eraser_Btn.TabIndex = 1;
            Eraser_Btn.UseVisualStyleBackColor = false;
            Eraser_Btn.Click += MainSelect;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.Location = new Point(1126, 19);
            label4.Name = "label4";
            label4.Size = new Size(148, 30);
            label4.TabIndex = 32;
            label4.Text = "Инструменты";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(898, 19);
            label3.Name = "label3";
            label3.Size = new Size(141, 30);
            label3.TabIndex = 31;
            label3.Text = "Фигуры";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(RegularTriangle_Btn);
            panel3.Controls.Add(RightTriangle_Btn);
            panel3.Controls.Add(Line_Btn);
            panel3.Controls.Add(Circle_Btn);
            panel3.Controls.Add(Rectangle_Btn);
            panel3.Location = new Point(856, 49);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 50);
            panel3.TabIndex = 30;
            // 
            // RegularTriangle_Btn
            // 
            RegularTriangle_Btn.Anchor = AnchorStyles.None;
            RegularTriangle_Btn.BackgroundImage = (Image)resources.GetObject("RegularTriangle_Btn.BackgroundImage");
            RegularTriangle_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            RegularTriangle_Btn.Cursor = Cursors.Hand;
            RegularTriangle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RegularTriangle_Btn.FlatAppearance.BorderSize = 0;
            RegularTriangle_Btn.FlatStyle = FlatStyle.Flat;
            RegularTriangle_Btn.ForeColor = Color.Black;
            RegularTriangle_Btn.Location = new Point(54, 8);
            RegularTriangle_Btn.Margin = new Padding(3, 2, 3, 2);
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
            RightTriangle_Btn.BackgroundImage = (Image)resources.GetObject("RightTriangle_Btn.BackgroundImage");
            RightTriangle_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            RightTriangle_Btn.Cursor = Cursors.Hand;
            RightTriangle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            RightTriangle_Btn.FlatAppearance.BorderSize = 0;
            RightTriangle_Btn.FlatStyle = FlatStyle.Flat;
            RightTriangle_Btn.ForeColor = Color.Black;
            RightTriangle_Btn.Location = new Point(136, 8);
            RightTriangle_Btn.Margin = new Padding(3, 2, 3, 2);
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
            Line_Btn.BackgroundImage = (Image)resources.GetObject("Line_Btn.BackgroundImage");
            Line_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Line_Btn.Cursor = Cursors.Hand;
            Line_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Line_Btn.FlatAppearance.BorderSize = 0;
            Line_Btn.FlatStyle = FlatStyle.Flat;
            Line_Btn.ForeColor = Color.Black;
            Line_Btn.Location = new Point(177, 8);
            Line_Btn.Margin = new Padding(3, 2, 3, 2);
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
            Circle_Btn.BackgroundImage = (Image)resources.GetObject("Circle_Btn.BackgroundImage");
            Circle_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Circle_Btn.Cursor = Cursors.Hand;
            Circle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Circle_Btn.FlatAppearance.BorderSize = 0;
            Circle_Btn.FlatStyle = FlatStyle.Flat;
            Circle_Btn.ForeColor = Color.Black;
            Circle_Btn.Location = new Point(13, 8);
            Circle_Btn.Margin = new Padding(3, 2, 3, 2);
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
            Rectangle_Btn.BackgroundImage = (Image)resources.GetObject("Rectangle_Btn.BackgroundImage");
            Rectangle_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            Rectangle_Btn.Cursor = Cursors.Hand;
            Rectangle_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Rectangle_Btn.FlatAppearance.BorderSize = 0;
            Rectangle_Btn.FlatStyle = FlatStyle.Flat;
            Rectangle_Btn.ForeColor = Color.Black;
            Rectangle_Btn.Location = new Point(95, 8);
            Rectangle_Btn.Margin = new Padding(3, 2, 3, 2);
            Rectangle_Btn.Name = "Rectangle_Btn";
            Rectangle_Btn.Size = new Size(32, 32);
            Rectangle_Btn.TabIndex = 1;
            Rectangle_Btn.Tag = "";
            Rectangle_Btn.UseVisualStyleBackColor = false;
            Rectangle_Btn.Click += MainSelect;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(993, 101);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 29;
            label2.Text = "Толщина кисти";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.None;
            trackBar1.Cursor = Cursors.Hand;
            trackBar1.Location = new Point(993, 136);
            trackBar1.Margin = new Padding(3, 2, 3, 2);
            trackBar1.Maximum = 7;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(166, 45);
            trackBar1.TabIndex = 28;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Value = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(467, 26);
            label1.Name = "label1";
            label1.Size = new Size(128, 26);
            label1.TabIndex = 26;
            label1.Text = "Палитра";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Brown_Btn);
            panel2.Controls.Add(SlateBlue_Btn);
            panel2.Controls.Add(DeepPink_Btn);
            panel2.Controls.Add(Aquamarine_Btn);
            panel2.Controls.Add(Green_Btn);
            panel2.Controls.Add(Fuchsia_Btn);
            panel2.Controls.Add(Blue_Btn);
            panel2.Controls.Add(Olive_Btn);
            panel2.Controls.Add(Purple_Btn);
            panel2.Controls.Add(Lime_Btn);
            panel2.Controls.Add(Orange_Btn);
            panel2.Controls.Add(Red_Btn);
            panel2.Controls.Add(Yellow_Btn);
            panel2.Controls.Add(Black_Btn);
            panel2.Controls.Add(Cyan_Btn);
            panel2.Location = new Point(446, 52);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(166, 100);
            panel2.TabIndex = 25;
            // 
            // Brown_Btn
            // 
            Brown_Btn.Anchor = AnchorStyles.None;
            Brown_Btn.BackColor = Color.SaddleBrown;
            Brown_Btn.Cursor = Cursors.Hand;
            Brown_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Brown_Btn.FlatAppearance.BorderSize = 0;
            Brown_Btn.FlatStyle = FlatStyle.Popup;
            Brown_Btn.Location = new Point(101, 67);
            Brown_Btn.Margin = new Padding(3, 2, 3, 2);
            Brown_Btn.Name = "Brown_Btn";
            Brown_Btn.Size = new Size(26, 26);
            Brown_Btn.TabIndex = 15;
            Brown_Btn.UseVisualStyleBackColor = false;
            Brown_Btn.Click += SelectColor;
            // 
            // SlateBlue_Btn
            // 
            SlateBlue_Btn.Anchor = AnchorStyles.None;
            SlateBlue_Btn.BackColor = Color.MediumSlateBlue;
            SlateBlue_Btn.Cursor = Cursors.Hand;
            SlateBlue_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            SlateBlue_Btn.FlatAppearance.BorderSize = 0;
            SlateBlue_Btn.FlatStyle = FlatStyle.Popup;
            SlateBlue_Btn.Location = new Point(132, 37);
            SlateBlue_Btn.Margin = new Padding(3, 2, 3, 2);
            SlateBlue_Btn.Name = "SlateBlue_Btn";
            SlateBlue_Btn.Size = new Size(26, 26);
            SlateBlue_Btn.TabIndex = 14;
            SlateBlue_Btn.UseVisualStyleBackColor = false;
            SlateBlue_Btn.Click += SelectColor;
            // 
            // DeepPink_Btn
            // 
            DeepPink_Btn.Anchor = AnchorStyles.None;
            DeepPink_Btn.BackColor = Color.DeepPink;
            DeepPink_Btn.Cursor = Cursors.Hand;
            DeepPink_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DeepPink_Btn.FlatAppearance.BorderSize = 0;
            DeepPink_Btn.FlatStyle = FlatStyle.Popup;
            DeepPink_Btn.Location = new Point(70, 37);
            DeepPink_Btn.Margin = new Padding(3, 2, 3, 2);
            DeepPink_Btn.Name = "DeepPink_Btn";
            DeepPink_Btn.Size = new Size(26, 26);
            DeepPink_Btn.TabIndex = 11;
            DeepPink_Btn.UseVisualStyleBackColor = false;
            DeepPink_Btn.Click += SelectColor;
            // 
            // Aquamarine_Btn
            // 
            Aquamarine_Btn.Anchor = AnchorStyles.None;
            Aquamarine_Btn.BackColor = Color.Aquamarine;
            Aquamarine_Btn.Cursor = Cursors.Hand;
            Aquamarine_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Aquamarine_Btn.FlatAppearance.BorderSize = 0;
            Aquamarine_Btn.FlatStyle = FlatStyle.Popup;
            Aquamarine_Btn.Location = new Point(38, 37);
            Aquamarine_Btn.Margin = new Padding(3, 2, 3, 2);
            Aquamarine_Btn.Name = "Aquamarine_Btn";
            Aquamarine_Btn.Size = new Size(26, 26);
            Aquamarine_Btn.TabIndex = 13;
            Aquamarine_Btn.UseVisualStyleBackColor = false;
            Aquamarine_Btn.Click += SelectColor;
            // 
            // Green_Btn
            // 
            Green_Btn.Anchor = AnchorStyles.None;
            Green_Btn.BackColor = Color.Green;
            Green_Btn.Cursor = Cursors.Hand;
            Green_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Green_Btn.FlatAppearance.BorderSize = 0;
            Green_Btn.FlatStyle = FlatStyle.Popup;
            Green_Btn.Location = new Point(132, 67);
            Green_Btn.Margin = new Padding(3, 2, 3, 2);
            Green_Btn.Name = "Green_Btn";
            Green_Btn.Size = new Size(26, 26);
            Green_Btn.TabIndex = 9;
            Green_Btn.UseVisualStyleBackColor = false;
            Green_Btn.Click += SelectColor;
            // 
            // Fuchsia_Btn
            // 
            Fuchsia_Btn.Anchor = AnchorStyles.None;
            Fuchsia_Btn.BackColor = Color.Fuchsia;
            Fuchsia_Btn.Cursor = Cursors.Hand;
            Fuchsia_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Fuchsia_Btn.FlatAppearance.BorderSize = 0;
            Fuchsia_Btn.FlatStyle = FlatStyle.Popup;
            Fuchsia_Btn.Location = new Point(38, 7);
            Fuchsia_Btn.Margin = new Padding(3, 2, 3, 2);
            Fuchsia_Btn.Name = "Fuchsia_Btn";
            Fuchsia_Btn.Size = new Size(26, 26);
            Fuchsia_Btn.TabIndex = 7;
            Fuchsia_Btn.UseVisualStyleBackColor = false;
            Fuchsia_Btn.Click += SelectColor;
            // 
            // Blue_Btn
            // 
            Blue_Btn.Anchor = AnchorStyles.None;
            Blue_Btn.BackColor = Color.Blue;
            Blue_Btn.Cursor = Cursors.Hand;
            Blue_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Blue_Btn.FlatAppearance.BorderSize = 0;
            Blue_Btn.FlatStyle = FlatStyle.Popup;
            Blue_Btn.Location = new Point(6, 67);
            Blue_Btn.Margin = new Padding(3, 2, 3, 2);
            Blue_Btn.Name = "Blue_Btn";
            Blue_Btn.Size = new Size(26, 26);
            Blue_Btn.TabIndex = 6;
            Blue_Btn.UseVisualStyleBackColor = false;
            Blue_Btn.Click += SelectColor;
            // 
            // Olive_Btn
            // 
            Olive_Btn.Anchor = AnchorStyles.None;
            Olive_Btn.BackColor = Color.Olive;
            Olive_Btn.Cursor = Cursors.Hand;
            Olive_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Olive_Btn.FlatAppearance.BorderSize = 0;
            Olive_Btn.FlatStyle = FlatStyle.Popup;
            Olive_Btn.Location = new Point(70, 67);
            Olive_Btn.Margin = new Padding(3, 2, 3, 2);
            Olive_Btn.Name = "Olive_Btn";
            Olive_Btn.Size = new Size(26, 26);
            Olive_Btn.TabIndex = 10;
            Olive_Btn.UseVisualStyleBackColor = false;
            Olive_Btn.Click += SelectColor;
            // 
            // Purple_Btn
            // 
            Purple_Btn.Anchor = AnchorStyles.None;
            Purple_Btn.BackColor = Color.Purple;
            Purple_Btn.Cursor = Cursors.Hand;
            Purple_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Purple_Btn.FlatAppearance.BorderSize = 0;
            Purple_Btn.FlatStyle = FlatStyle.Popup;
            Purple_Btn.Location = new Point(38, 67);
            Purple_Btn.Margin = new Padding(3, 2, 3, 2);
            Purple_Btn.Name = "Purple_Btn";
            Purple_Btn.Size = new Size(26, 26);
            Purple_Btn.TabIndex = 8;
            Purple_Btn.UseVisualStyleBackColor = false;
            Purple_Btn.Click += SelectColor;
            // 
            // Lime_Btn
            // 
            Lime_Btn.Anchor = AnchorStyles.None;
            Lime_Btn.BackColor = Color.Lime;
            Lime_Btn.Cursor = Cursors.Hand;
            Lime_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Lime_Btn.FlatAppearance.BorderSize = 0;
            Lime_Btn.FlatStyle = FlatStyle.Popup;
            Lime_Btn.Location = new Point(6, 37);
            Lime_Btn.Margin = new Padding(3, 2, 3, 2);
            Lime_Btn.Name = "Lime_Btn";
            Lime_Btn.Size = new Size(26, 26);
            Lime_Btn.TabIndex = 4;
            Lime_Btn.UseVisualStyleBackColor = false;
            Lime_Btn.Click += SelectColor;
            // 
            // Orange_Btn
            // 
            Orange_Btn.Anchor = AnchorStyles.None;
            Orange_Btn.BackColor = Color.DarkOrange;
            Orange_Btn.Cursor = Cursors.Hand;
            Orange_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Orange_Btn.FlatAppearance.BorderSize = 0;
            Orange_Btn.FlatStyle = FlatStyle.Popup;
            Orange_Btn.Location = new Point(101, 7);
            Orange_Btn.Margin = new Padding(3, 2, 3, 2);
            Orange_Btn.Name = "Orange_Btn";
            Orange_Btn.Size = new Size(26, 26);
            Orange_Btn.TabIndex = 2;
            Orange_Btn.UseVisualStyleBackColor = false;
            Orange_Btn.Click += SelectColor;
            // 
            // Red_Btn
            // 
            Red_Btn.Anchor = AnchorStyles.None;
            Red_Btn.BackColor = Color.Red;
            Red_Btn.Cursor = Cursors.Hand;
            Red_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Red_Btn.FlatAppearance.BorderSize = 0;
            Red_Btn.FlatStyle = FlatStyle.Popup;
            Red_Btn.Location = new Point(70, 7);
            Red_Btn.Margin = new Padding(3, 2, 3, 2);
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
            Yellow_Btn.Cursor = Cursors.Hand;
            Yellow_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Yellow_Btn.FlatAppearance.BorderSize = 0;
            Yellow_Btn.FlatStyle = FlatStyle.Popup;
            Yellow_Btn.Location = new Point(132, 7);
            Yellow_Btn.Margin = new Padding(3, 2, 3, 2);
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
            Black_Btn.Cursor = Cursors.Hand;
            Black_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Black_Btn.FlatAppearance.BorderSize = 0;
            Black_Btn.FlatStyle = FlatStyle.Popup;
            Black_Btn.Location = new Point(6, 7);
            Black_Btn.Margin = new Padding(3, 2, 3, 2);
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
            Cyan_Btn.Cursor = Cursors.Hand;
            Cyan_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Cyan_Btn.FlatAppearance.BorderSize = 0;
            Cyan_Btn.FlatStyle = FlatStyle.Popup;
            Cyan_Btn.Location = new Point(101, 37);
            Cyan_Btn.Margin = new Padding(3, 2, 3, 2);
            Cyan_Btn.Name = "Cyan_Btn";
            Cyan_Btn.Size = new Size(26, 26);
            Cyan_Btn.TabIndex = 5;
            Cyan_Btn.UseVisualStyleBackColor = false;
            Cyan_Btn.Click += SelectColor;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(DM_Btn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CurrentColor_B);
            panel1.Controls.Add(CurrentColor_G);
            panel1.Controls.Add(CurrentColor_R);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(CurrentColorInHTML);
            panel1.Controls.Add(ColorSlider_B);
            panel1.Controls.Add(ColorSlider_G);
            panel1.Controls.Add(ColorSlider_R);
            panel1.Controls.Add(CurrentColor_Btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SelectFile_Btn);
            panel1.Controls.Add(ClearBoard_Btn);
            panel1.Controls.Add(SaveFile_Btn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(trackBar1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1800, 186);
            panel1.TabIndex = 42;
            // 
            // DM_Btn
            // 
            DM_Btn.Anchor = AnchorStyles.None;
            DM_Btn.FlatAppearance.BorderSize = 0;
            DM_Btn.FlatStyle = FlatStyle.Popup;
            DM_Btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            DM_Btn.Location = new Point(305, 12);
            DM_Btn.Name = "DM_Btn";
            DM_Btn.Size = new Size(135, 49);
            DM_Btn.TabIndex = 57;
            DM_Btn.Text = "Тёмная тема: Выкл";
            DM_Btn.UseVisualStyleBackColor = false;
            DM_Btn.Click += DM_Btn_Click;
            // 
            // CurrentColor_B
            // 
            CurrentColor_B.Anchor = AnchorStyles.None;
            CurrentColor_B.BackColor = Color.WhiteSmoke;
            CurrentColor_B.BorderStyle = BorderStyle.FixedSingle;
            CurrentColor_B.Cursor = Cursors.IBeam;
            CurrentColor_B.ForeColor = Color.Black;
            CurrentColor_B.Location = new Point(792, 138);
            CurrentColor_B.Margin = new Padding(3, 2, 3, 2);
            CurrentColor_B.Name = "CurrentColor_B";
            CurrentColor_B.Size = new Size(37, 31);
            CurrentColor_B.TabIndex = 56;
            CurrentColor_B.KeyPress += ColorFromChangingRGBTextboxes;
            // 
            // CurrentColor_G
            // 
            CurrentColor_G.Anchor = AnchorStyles.None;
            CurrentColor_G.BackColor = Color.WhiteSmoke;
            CurrentColor_G.BorderStyle = BorderStyle.FixedSingle;
            CurrentColor_G.Cursor = Cursors.IBeam;
            CurrentColor_G.ForeColor = Color.Black;
            CurrentColor_G.Location = new Point(792, 99);
            CurrentColor_G.Margin = new Padding(3, 2, 3, 2);
            CurrentColor_G.Name = "CurrentColor_G";
            CurrentColor_G.Size = new Size(37, 31);
            CurrentColor_G.TabIndex = 55;
            CurrentColor_G.KeyPress += ColorFromChangingRGBTextboxes;
            // 
            // CurrentColor_R
            // 
            CurrentColor_R.Anchor = AnchorStyles.None;
            CurrentColor_R.BackColor = Color.WhiteSmoke;
            CurrentColor_R.BorderStyle = BorderStyle.FixedSingle;
            CurrentColor_R.Cursor = Cursors.IBeam;
            CurrentColor_R.ForeColor = Color.Black;
            CurrentColor_R.Location = new Point(792, 59);
            CurrentColor_R.Margin = new Padding(3, 2, 3, 2);
            CurrentColor_R.Name = "CurrentColor_R";
            CurrentColor_R.Size = new Size(37, 31);
            CurrentColor_R.TabIndex = 54;
            CurrentColor_R.KeyPress += ColorFromChangingRGBTextboxes;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(630, 136);
            label8.Name = "label8";
            label8.Size = new Size(21, 22);
            label8.TabIndex = 53;
            label8.Text = "B";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(630, 95);
            label7.Name = "label7";
            label7.Size = new Size(21, 22);
            label7.TabIndex = 52;
            label7.Text = "G";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(630, 57);
            label6.Name = "label6";
            label6.Size = new Size(21, 22);
            label6.TabIndex = 51;
            label6.Text = "R";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CurrentColorInHTML
            // 
            CurrentColorInHTML.Anchor = AnchorStyles.None;
            CurrentColorInHTML.BackColor = Color.WhiteSmoke;
            CurrentColorInHTML.BorderStyle = BorderStyle.FixedSingle;
            CurrentColorInHTML.Cursor = Cursors.IBeam;
            CurrentColorInHTML.ForeColor = Color.Black;
            CurrentColorInHTML.Location = new Point(714, 21);
            CurrentColorInHTML.Margin = new Padding(3, 2, 3, 2);
            CurrentColorInHTML.Name = "CurrentColorInHTML";
            CurrentColorInHTML.Size = new Size(115, 31);
            CurrentColorInHTML.TabIndex = 50;
            CurrentColorInHTML.KeyPress += ColorInHTML_KeyPress;
            // 
            // ColorSlider_B
            // 
            ColorSlider_B.Anchor = AnchorStyles.None;
            ColorSlider_B.AutoSize = false;
            ColorSlider_B.Cursor = Cursors.Hand;
            ColorSlider_B.Location = new Point(648, 132);
            ColorSlider_B.Margin = new Padding(3, 2, 3, 2);
            ColorSlider_B.Maximum = 255;
            ColorSlider_B.Name = "ColorSlider_B";
            ColorSlider_B.Size = new Size(149, 35);
            ColorSlider_B.TabIndex = 49;
            ColorSlider_B.TickStyle = TickStyle.Both;
            ColorSlider_B.Scroll += ColorFromChangingSlider;
            // 
            // ColorSlider_G
            // 
            ColorSlider_G.Anchor = AnchorStyles.None;
            ColorSlider_G.AutoSize = false;
            ColorSlider_G.Cursor = Cursors.Hand;
            ColorSlider_G.Location = new Point(648, 92);
            ColorSlider_G.Margin = new Padding(3, 2, 3, 2);
            ColorSlider_G.Maximum = 255;
            ColorSlider_G.Name = "ColorSlider_G";
            ColorSlider_G.Size = new Size(149, 35);
            ColorSlider_G.TabIndex = 48;
            ColorSlider_G.TickStyle = TickStyle.Both;
            ColorSlider_G.Scroll += ColorFromChangingSlider;
            // 
            // ColorSlider_R
            // 
            ColorSlider_R.Anchor = AnchorStyles.None;
            ColorSlider_R.AutoSize = false;
            ColorSlider_R.Cursor = Cursors.Hand;
            ColorSlider_R.Location = new Point(648, 52);
            ColorSlider_R.Margin = new Padding(3, 2, 3, 2);
            ColorSlider_R.Maximum = 255;
            ColorSlider_R.Name = "ColorSlider_R";
            ColorSlider_R.Size = new Size(149, 35);
            ColorSlider_R.TabIndex = 47;
            ColorSlider_R.TickStyle = TickStyle.Both;
            ColorSlider_R.Scroll += ColorFromChangingSlider;
            // 
            // CurrentColor_Btn
            // 
            CurrentColor_Btn.Anchor = AnchorStyles.None;
            CurrentColor_Btn.BackColor = Color.Fuchsia;
            CurrentColor_Btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            CurrentColor_Btn.FlatAppearance.BorderSize = 0;
            CurrentColor_Btn.FlatStyle = FlatStyle.Popup;
            CurrentColor_Btn.Location = new Point(630, 25);
            CurrentColor_Btn.Margin = new Padding(3, 2, 3, 2);
            CurrentColor_Btn.Name = "CurrentColor_Btn";
            CurrentColor_Btn.Size = new Size(80, 23);
            CurrentColor_Btn.TabIndex = 45;
            CurrentColor_Btn.UseVisualStyleBackColor = false;
            // 
            // SelectFile_Btn
            // 
            SelectFile_Btn.Anchor = AnchorStyles.None;
            SelectFile_Btn.Cursor = Cursors.Hand;
            SelectFile_Btn.FlatAppearance.BorderColor = Color.Black;
            SelectFile_Btn.FlatAppearance.BorderSize = 0;
            SelectFile_Btn.FlatStyle = FlatStyle.Popup;
            SelectFile_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SelectFile_Btn.Location = new Point(1307, 67);
            SelectFile_Btn.Margin = new Padding(3, 2, 3, 2);
            SelectFile_Btn.Name = "SelectFile_Btn";
            SelectFile_Btn.Size = new Size(175, 55);
            SelectFile_Btn.TabIndex = 42;
            SelectFile_Btn.Text = "Выбрать изображение";
            SelectFile_Btn.UseVisualStyleBackColor = false;
            SelectFile_Btn.Click += SelectFile_Btn_Click;
            // 
            // MainImage
            // 
            MainImage.Anchor = AnchorStyles.None;
            MainImage.BackColor = Color.White;
            MainImage.Cursor = Cursors.Cross;
            MainImage.Location = new Point(65, 200);
            MainImage.Margin = new Padding(3, 2, 3, 2);
            MainImage.Name = "MainImage";
            MainImage.Size = new Size(1680, 720);
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
            CoordinatesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CoordinatesLabel.Location = new Point(10, 920);
            CoordinatesLabel.Name = "CoordinatesLabel";
            CoordinatesLabel.Size = new Size(124, 23);
            CoordinatesLabel.TabIndex = 44;
            CoordinatesLabel.Text = "x: 0; y: 0";
            CoordinatesLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 175, 175);
            ClientSize = new Size(1800, 949);
            Controls.Add(CoordinatesLabel);
            Controls.Add(panel1);
            Controls.Add(MainImage);
            Icon = Properties.Resources.Icon;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Pint v4.0.0";
            KeyDown += Form1_KeyDown;
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_G).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorSlider_R).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainImage).EndInit();
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
        private Panel panel3;
        private Button RegularTriangle_Btn;
        private Button RightTriangle_Btn;
        private Button Line_Btn;
        private Button Circle_Btn;
        private Button Rectangle_Btn;
        private Label label2;
        private TrackBar trackBar1;
        private Label label1;
        private Panel panel2;
        private Button Green_Btn;
        private Button Purple_Btn;
        private Button Fuchsia_Btn;
        private Button Blue_Btn;
        private Button Cyan_Btn;
        private Button Lime_Btn;
        private Button Yellow_Btn;
        private Button Orange_Btn;
        private Button Red_Btn;
        private Button Black_Btn;
        private Panel panel1;
        private Button SelectFile_Btn;
        private System.Windows.Forms.Timer DrawingTimer;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button DeepPink_Btn;
        private Button Olive_Btn;
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
        private Button Brown_Btn;
        private Button Aquamarine_Btn;
        private Button SlateBlue_Btn;
        private Button DM_Btn;
        private Label CoordinatesLabel;
    }
}
