namespace TalkBot
{
    partial class ImagePreviewForm
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
            this.PreviewImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewImageBox
            // 
            this.PreviewImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewImageBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewImageBox.Name = "PreviewImageBox";
            this.PreviewImageBox.Size = new System.Drawing.Size(284, 262);
            this.PreviewImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PreviewImageBox.TabIndex = 0;
            this.PreviewImageBox.TabStop = false;
            // 
            // ImagePreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PreviewImageBox);
            this.Name = "ImagePreviewForm";
            this.ShowIcon = false;
            this.Text = "顔の画像プレビュー";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PreviewImageBox;
    }
}