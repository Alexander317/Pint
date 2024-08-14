namespace CustomPaint
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
            applyButton = new Button();
            label1 = new Label();
            label2 = new Label();
            widthNumeric = new NumericUpDown();
            heightNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)widthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).BeginInit();
            SuspendLayout();
            // 
            // applyButton
            // 
            applyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            applyButton.FlatAppearance.BorderSize = 0;
            applyButton.FlatStyle = FlatStyle.Popup;
            applyButton.Location = new Point(29, 125);
            applyButton.Margin = new Padding(20, 3, 20, 3);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(132, 40);
            applyButton.TabIndex = 0;
            applyButton.Text = "Change";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += ApplyButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 14);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 46);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Height";
            // 
            // widthNumeric
            // 
            widthNumeric.Location = new Point(94, 12);
            widthNumeric.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            widthNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            widthNumeric.Name = "widthNumeric";
            widthNumeric.Size = new Size(84, 23);
            widthNumeric.TabIndex = 5;
            widthNumeric.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            // 
            // heightNumeric
            // 
            heightNumeric.Location = new Point(94, 44);
            heightNumeric.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            heightNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            heightNumeric.Name = "heightNumeric";
            heightNumeric.Size = new Size(84, 23);
            heightNumeric.TabIndex = 6;
            heightNumeric.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            // 
            // SizeChooseDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(190, 177);
            Controls.Add(heightNumeric);
            Controls.Add(widthNumeric);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(applyButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SizeChooseDialog";
            ShowInTaskbar = false;
            Text = "Choose Canvas Size";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)widthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button applyButton;
        private Label label1;
        private Label label2;
        private NumericUpDown widthNumeric;
        private NumericUpDown heightNumeric;
    }
}