namespace Pint
{
    partial class ScrollablePictureBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlParent = new Panel();
            pictureBox = new PictureBox();
            pnlParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pnlParent
            // 
            pnlParent.AutoScroll = true;
            pnlParent.Controls.Add(pictureBox);
            pnlParent.Dock = DockStyle.Fill;
            pnlParent.Location = new Point(0, 0);
            pnlParent.Name = "pnlParent";
            pnlParent.Size = new Size(441, 289);
            pnlParent.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(441, 289);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // ScrollablePictureBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlParent);
            Name = "ScrollablePictureBox";
            Size = new Size(441, 289);
            pnlParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlParent;
        private PictureBox pictureBox;
    }
}
