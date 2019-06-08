namespace BRL.Pages
{
    partial class AesKeys
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.aesKeysBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1156, 41);
            this.Title.TabIndex = 0;
            this.Title.Text = "Aes Keys";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aesKeysBox
            // 
            this.aesKeysBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.aesKeysBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aesKeysBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aesKeysBox.ForeColor = System.Drawing.Color.White;
            this.aesKeysBox.Location = new System.Drawing.Point(0, 41);
            this.aesKeysBox.Name = "aesKeysBox";
            this.aesKeysBox.ReadOnly = true;
            this.aesKeysBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.aesKeysBox.Size = new System.Drawing.Size(1156, 594);
            this.aesKeysBox.TabIndex = 1;
            this.aesKeysBox.Text = "";
            // 
            // AesKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.aesKeysBox);
            this.Controls.Add(this.Title);
            this.Name = "AesKeys";
            this.Size = new System.Drawing.Size(1156, 635);
            this.Load += new System.EventHandler(this.AesKeys_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox aesKeysBox;
    }
}
