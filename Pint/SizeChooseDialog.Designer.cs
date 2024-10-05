namespace Pint
{
    partial class SizeChooseDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            heightNumeric = new NumericUpDown();
            widthNumeric = new NumericUpDown();
            applyButton = new RoundButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(164, 19);
            label1.TabIndex = 3;
            label1.Text = "Ширина изображения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(11, 45);
            label2.Name = "label2";
            label2.Size = new Size(156, 19);
            label2.TabIndex = 4;
            label2.Text = "Высота изображения";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(heightNumeric);
            panel1.Controls.Add(widthNumeric);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 78);
            panel1.TabIndex = 7;
            // 
            // heightNumeric
            // 
            heightNumeric.Font = new Font("Calibri", 12F);
            heightNumeric.InterceptArrowKeys = false;
            heightNumeric.Location = new Point(181, 44);
            heightNumeric.Maximum = new decimal(new int[] { 32768, 0, 0, 0 });
            heightNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            heightNumeric.Name = "heightNumeric";
            heightNumeric.Size = new Size(84, 27);
            heightNumeric.TabIndex = 45;
            heightNumeric.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            heightNumeric.KeyDown += Numerics_KeyDown;
            // 
            // widthNumeric
            // 
            widthNumeric.Font = new Font("Calibri", 12F);
            widthNumeric.InterceptArrowKeys = false;
            widthNumeric.Location = new Point(181, 10);
            widthNumeric.Maximum = new decimal(new int[] { 32768, 0, 0, 0 });
            widthNumeric.Name = "widthNumeric";
            widthNumeric.Size = new Size(84, 27);
            widthNumeric.TabIndex = 44;
            widthNumeric.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            widthNumeric.KeyDown += Numerics_KeyDown;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.WhiteSmoke;
            applyButton.BorderRadius = 16;
            applyButton.BorderWidth = 0F;
            applyButton.FlatAppearance.BorderColor = Color.Black;
            applyButton.FlatAppearance.BorderSize = 0;
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            applyButton.ForeColor = Color.Black;
            applyButton.Location = new Point(44, 95);
            applyButton.Name = "applyButton";
            applyButton.RoundBottomLeft = true;
            applyButton.RoundBottomRight = true;
            applyButton.RoundTopLeft = true;
            applyButton.RoundTopRight = true;
            applyButton.Size = new Size(192, 41);
            applyButton.TabIndex = 43;
            applyButton.Text = "Создать";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += ApplyButton_Click;
            // 
            // SizeChooseDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 205, 205);
            ClientSize = new Size(280, 148);
            Controls.Add(applyButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SizeChooseDialog";
            ShowInTaskbar = false;
            Text = "Выберите размер изображения";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel panel1;
        private RoundButton applyButton;
        private NumericUpDown heightNumeric;
        private NumericUpDown widthNumeric;
    }
}