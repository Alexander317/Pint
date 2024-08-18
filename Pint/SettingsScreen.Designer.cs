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
            groupBox1 = new GroupBox();
            label1 = new Label();
            darkTheme = new RadioButton();
            lightTheme = new RadioButton();
            groupBox2 = new GroupBox();
            label2 = new Label();
            useAgressiveFilling = new RadioButton();
            dontUseAgressiveFilling = new RadioButton();
            groupBox3 = new GroupBox();
            label3 = new Label();
            useAntiAliasing = new RadioButton();
            dontUseAntiAliasing = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(darkTheme);
            groupBox1.Controls.Add(lightTheme);
            groupBox1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тема приложения";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(8, 29);
            label1.Name = "label1";
            label1.Size = new Size(342, 19);
            label1.TabIndex = 3;
            label1.Text = "Определяет тему приложения для отображения";
            // 
            // darkTheme
            // 
            darkTheme.AutoSize = true;
            darkTheme.Font = new Font("Calibri", 13F);
            darkTheme.Location = new Point(31, 83);
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
            lightTheme.Location = new Point(31, 51);
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
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(useAgressiveFilling);
            groupBox2.Controls.Add(dontUseAgressiveFilling);
            groupBox2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(12, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 173);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Более агрессивная заливка";
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 11F);
            label2.Location = new Point(8, 29);
            label2.Name = "label2";
            label2.Size = new Size(508, 67);
            label2.TabIndex = 3;
            label2.Text = "Определяет, будет ли использоваться более агрессивный метод заливки фигуры (Лучше всего использовать когда цвета заливки и контура фигуры совпадают. Может привести к графическим ошибкам)";
            // 
            // useAgressiveFilling
            // 
            useAgressiveFilling.AutoSize = true;
            useAgressiveFilling.Font = new Font("Calibri", 13F);
            useAgressiveFilling.Location = new Point(31, 99);
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
            dontUseAgressiveFilling.Location = new Point(31, 131);
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
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(useAntiAliasing);
            groupBox3.Controls.Add(dontUseAntiAliasing);
            groupBox3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(12, 418);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(522, 167);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Технология Anti-Aliasing";
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 11F);
            label3.Location = new Point(8, 29);
            label3.Name = "label3";
            label3.Size = new Size(508, 64);
            label3.TabIndex = 3;
            label3.Text = "Определяет, будет ли использоваться технология сглаживания Anti-Aliasing. Значительно улучшает качество картинки, но может привести к графическим ошибкам при использовании вместе с заливкой";
            // 
            // useAntiAliasing
            // 
            useAntiAliasing.AutoSize = true;
            useAntiAliasing.Font = new Font("Calibri", 13F);
            useAntiAliasing.Location = new Point(31, 96);
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
            dontUseAntiAliasing.Location = new Point(31, 128);
            dontUseAntiAliasing.Name = "dontUseAntiAliasing";
            dontUseAntiAliasing.Size = new Size(157, 26);
            dontUseAntiAliasing.TabIndex = 1;
            dontUseAntiAliasing.TabStop = true;
            dontUseAntiAliasing.Text = "Не использовать";
            dontUseAntiAliasing.UseVisualStyleBackColor = true;
            dontUseAntiAliasing.CheckedChanged += dontUseAntiAliasing_CheckedChanged;
            // 
            // SettingsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 195, 195);
            ClientSize = new Size(546, 615);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SettingsScreen";
            Text = "Настройки";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton darkTheme;
        private RadioButton lightTheme;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private RadioButton useAgressiveFilling;
        private RadioButton dontUseAgressiveFilling;
        private GroupBox groupBox3;
        private Label label3;
        private RadioButton useAntiAliasing;
        private RadioButton dontUseAntiAliasing;
    }
}