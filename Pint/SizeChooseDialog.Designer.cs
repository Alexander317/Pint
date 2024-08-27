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
            widthNumeric = new NumericUpDown();
            heightNumeric = new NumericUpDown();
            panel1 = new Panel();
            applyButton = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)widthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).BeginInit();
            panel1.SuspendLayout();
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
            label2.Location = new Point(11, 41);
            label2.Name = "label2";
            label2.Size = new Size(156, 19);
            label2.TabIndex = 4;
            label2.Text = "Высота изображения";
            // 
            // widthNumeric
            // 
            widthNumeric.Font = new Font("Segoe UI", 9.75F);
            widthNumeric.Location = new Point(181, 12);
            widthNumeric.Maximum = new decimal(new int[] { 3840, 0, 0, 0 });
            widthNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            widthNumeric.Name = "widthNumeric";
            widthNumeric.Size = new Size(84, 25);
            widthNumeric.TabIndex = 5;
            widthNumeric.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            // 
            // heightNumeric
            // 
            heightNumeric.Font = new Font("Segoe UI", 9.75F);
            heightNumeric.Location = new Point(181, 41);
            heightNumeric.Maximum = new decimal(new int[] { 2160, 0, 0, 0 });
            heightNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            heightNumeric.Name = "heightNumeric";
            heightNumeric.Size = new Size(84, 25);
            heightNumeric.TabIndex = 6;
            heightNumeric.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(heightNumeric);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(widthNumeric);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 78);
            panel1.TabIndex = 7;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.Transparent;
            applyButton.BorderRadius = 12;
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
            ((System.ComponentModel.ISupportInitialize)widthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private NumericUpDown widthNumeric;
        private NumericUpDown heightNumeric;
        private Panel panel1;
        private RoundButton applyButton;
    }
}