using Pint.AdditionalToolbox;

namespace Pint
{
    partial class SettingsScreen
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
            groupBox1 = new RoundGroupBox();
            label1 = new Label();
            darkTheme = new RadioButton();
            lightTheme = new RadioButton();
            groupBox2 = new RoundGroupBox();
            label2 = new Label();
            useAgressiveFilling = new RadioButton();
            dontUseAgressiveFilling = new RadioButton();
            groupBox3 = new RoundGroupBox();
            label3 = new Label();
            useAntiAliasing = new RadioButton();
            dontUseAntiAliasing = new RadioButton();
            groupBox4 = new RoundGroupBox();
            label4 = new Label();
            useExtendedCtrl = new RadioButton();
            dontUseExtendedCtrl = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.BorderRadius = 12;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(darkTheme);
            groupBox1.Controls.Add(lightTheme);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Calibri", 15F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(17, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.RoundBottomLeft = true;
            groupBox1.RoundBottomRight = true;
            groupBox1.RoundTopLeft = true;
            groupBox1.RoundTopRight = true;
            groupBox1.Size = new Size(330, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тема приложения";
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(10, 37);
            label1.Name = "label1";
            label1.Size = new Size(320, 40);
            label1.TabIndex = 3;
            label1.Text = "Определяет тему приложения для отображения";
            // 
            // darkTheme
            // 
            darkTheme.AutoSize = true;
            darkTheme.Font = new Font("Calibri", 13F);
            darkTheme.Location = new Point(25, 123);
            darkTheme.Name = "darkTheme";
            darkTheme.Size = new Size(84, 26);
            darkTheme.TabIndex = 2;
            darkTheme.TabStop = true;
            darkTheme.Text = "Тёмная";
            darkTheme.UseVisualStyleBackColor = true;
            darkTheme.CheckedChanged += darkTheme_CheckedChanged;
            // 
            // lightTheme
            // 
            lightTheme.AutoSize = true;
            lightTheme.Font = new Font("Calibri", 13F);
            lightTheme.Location = new Point(25, 91);
            lightTheme.Name = "lightTheme";
            lightTheme.Size = new Size(89, 26);
            lightTheme.TabIndex = 1;
            lightTheme.TabStop = true;
            lightTheme.Text = "Светлая";
            lightTheme.UseVisualStyleBackColor = true;
            lightTheme.CheckedChanged += lightTheme_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.BorderRadius = 12;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(useAgressiveFilling);
            groupBox2.Controls.Add(dontUseAgressiveFilling);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Calibri", 15F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(17, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.RoundBottomLeft = true;
            groupBox2.RoundBottomRight = true;
            groupBox2.RoundTopLeft = true;
            groupBox2.RoundTopRight = true;
            groupBox2.Size = new Size(330, 200);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Более агрессивная заливка";
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(309, 91);
            label2.TabIndex = 3;
            label2.Text = "Определяет, будет ли использоваться более агрессивный метод заливки фигуры (Может привести к графическим ошибкам)";
            // 
            // useAgressiveFilling
            // 
            useAgressiveFilling.AutoSize = true;
            useAgressiveFilling.Font = new Font("Calibri", 13F);
            useAgressiveFilling.Location = new Point(25, 129);
            useAgressiveFilling.Name = "useAgressiveFilling";
            useAgressiveFilling.Size = new Size(135, 26);
            useAgressiveFilling.TabIndex = 2;
            useAgressiveFilling.TabStop = true;
            useAgressiveFilling.Text = "Использовать";
            useAgressiveFilling.UseVisualStyleBackColor = true;
            useAgressiveFilling.CheckedChanged += useAgressiveFilling_CheckedChanged;
            // 
            // dontUseAgressiveFilling
            // 
            dontUseAgressiveFilling.AutoSize = true;
            dontUseAgressiveFilling.Font = new Font("Calibri", 13F);
            dontUseAgressiveFilling.Location = new Point(25, 161);
            dontUseAgressiveFilling.Name = "dontUseAgressiveFilling";
            dontUseAgressiveFilling.Size = new Size(157, 26);
            dontUseAgressiveFilling.TabIndex = 1;
            dontUseAgressiveFilling.TabStop = true;
            dontUseAgressiveFilling.Text = "Не использовать";
            dontUseAgressiveFilling.UseVisualStyleBackColor = true;
            dontUseAgressiveFilling.CheckedChanged += dontUseAgressiveFilling_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.BorderRadius = 12;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(useAntiAliasing);
            groupBox3.Controls.Add(dontUseAntiAliasing);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Calibri", 15F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(374, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.RoundBottomLeft = true;
            groupBox3.RoundBottomRight = true;
            groupBox3.RoundTopLeft = true;
            groupBox3.RoundTopRight = true;
            groupBox3.Size = new Size(330, 200);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Технология Anti-Aliasing";
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(10, 37);
            label3.Name = "label3";
            label3.Size = new Size(295, 93);
            label3.TabIndex = 3;
            label3.Text = "Определяет, будет ли использоваться технология сглаживания Anti-Aliasing. Значительно улучшает качество картинки";
            // 
            // useAntiAliasing
            // 
            useAntiAliasing.AutoSize = true;
            useAntiAliasing.Font = new Font("Calibri", 13F);
            useAntiAliasing.Location = new Point(25, 130);
            useAntiAliasing.Name = "useAntiAliasing";
            useAntiAliasing.Size = new Size(135, 26);
            useAntiAliasing.TabIndex = 2;
            useAntiAliasing.TabStop = true;
            useAntiAliasing.Text = "Использовать";
            useAntiAliasing.UseVisualStyleBackColor = true;
            useAntiAliasing.CheckedChanged += useAntiAliasing_CheckedChanged;
            // 
            // dontUseAntiAliasing
            // 
            dontUseAntiAliasing.AutoSize = true;
            dontUseAntiAliasing.Font = new Font("Calibri", 13F);
            dontUseAntiAliasing.Location = new Point(25, 162);
            dontUseAntiAliasing.Name = "dontUseAntiAliasing";
            dontUseAntiAliasing.Size = new Size(157, 26);
            dontUseAntiAliasing.TabIndex = 1;
            dontUseAntiAliasing.TabStop = true;
            dontUseAntiAliasing.Text = "Не использовать";
            dontUseAntiAliasing.UseVisualStyleBackColor = true;
            dontUseAntiAliasing.CheckedChanged += dontUseAntiAliasing_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.BorderRadius = 12;
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(useExtendedCtrl);
            groupBox4.Controls.Add(dontUseExtendedCtrl);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Calibri", 15F, FontStyle.Bold);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(374, 250);
            groupBox4.Name = "groupBox4";
            groupBox4.RoundBottomLeft = true;
            groupBox4.RoundBottomRight = true;
            groupBox4.RoundTopLeft = true;
            groupBox4.RoundTopRight = true;
            groupBox4.Size = new Size(330, 157);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ctrl+Z и Ctrl+Y";
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(10, 37);
            label4.Name = "label4";
            label4.Size = new Size(314, 38);
            label4.TabIndex = 3;
            label4.Text = "Определяет, могут ли использоваться сочетания клавиш Ctrl+Z и Ctrl+Y";
            // 
            // useExtendedCtrl
            // 
            useExtendedCtrl.AutoSize = true;
            useExtendedCtrl.Font = new Font("Calibri", 13F);
            useExtendedCtrl.Location = new Point(25, 85);
            useExtendedCtrl.Name = "useExtendedCtrl";
            useExtendedCtrl.Size = new Size(135, 26);
            useExtendedCtrl.TabIndex = 2;
            useExtendedCtrl.TabStop = true;
            useExtendedCtrl.Text = "Использовать";
            useExtendedCtrl.UseVisualStyleBackColor = true;
            useExtendedCtrl.CheckedChanged += useExtendedCtrl_CheckedChanged;
            // 
            // dontUseExtendedCtrl
            // 
            dontUseExtendedCtrl.AutoSize = true;
            dontUseExtendedCtrl.Font = new Font("Calibri", 13F);
            dontUseExtendedCtrl.Location = new Point(25, 117);
            dontUseExtendedCtrl.Name = "dontUseExtendedCtrl";
            dontUseExtendedCtrl.Size = new Size(157, 26);
            dontUseExtendedCtrl.TabIndex = 1;
            dontUseExtendedCtrl.TabStop = true;
            dontUseExtendedCtrl.Text = "Не использовать";
            dontUseExtendedCtrl.UseVisualStyleBackColor = true;
            dontUseExtendedCtrl.CheckedChanged += dontUseExtendedCtrl_CheckedChanged;
            // 
            // SettingsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 195, 195);
            ClientSize = new Size(727, 427);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SettingsScreen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton darkTheme;
        private RadioButton lightTheme;
        private Label label1;
        private Label label2;
        private RadioButton useAgressiveFilling;
        private RadioButton dontUseAgressiveFilling;
        private Label label3;
        private RadioButton useAntiAliasing;
        private RadioButton dontUseAntiAliasing;
        private RoundGroupBox groupBox1;
        private RoundGroupBox groupBox2;
        private RoundGroupBox groupBox3;
        private RoundGroupBox groupBox4;
        private Label label4;
        private RadioButton useExtendedCtrl;
        private RadioButton dontUseExtendedCtrl;
    }
}