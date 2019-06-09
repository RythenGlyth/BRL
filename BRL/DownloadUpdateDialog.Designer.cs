namespace BRL
{
    partial class DownloadUpdateDialog
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.title = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.labelInformation = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(484, 281);
            this.progressBar.TabIndex = 0;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Burbank Big Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(484, 30);
            this.title.TabIndex = 1;
            this.title.Text = "Updating...";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressLabel
            // 
            this.progressLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(0, 281);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(484, 30);
            this.progressLabel.TabIndex = 2;
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Controls.Add(this.labelInformation);
            this.header.Controls.Add(this.title);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(484, 30);
            this.header.TabIndex = 3;
            // 
            // labelInformation
            // 
            this.labelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInformation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(422, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(62, 30);
            this.labelInformation.TabIndex = 2;
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DownloadUpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.header);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.progressLabel);
            this.Name = "DownloadUpdateDialog";
            this.Text = "UpdateWindow";
            this.Load += new System.EventHandler(this.DownloadUpdateDialog_Load);
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label labelInformation;
    }
}