using System.Drawing.Text;

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
            this.aesKeysTable = new System.Windows.Forms.TableLayoutPanel();
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
            this.Title.Text = "AES Keys";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aesKeysTable
            // 
            this.aesKeysTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.aesKeysTable.ColumnCount = 2;
            this.aesKeysTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aesKeysTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aesKeysTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aesKeysTable.Location = new System.Drawing.Point(0, 41);
            this.aesKeysTable.Name = "aesKeysTable";
            this.aesKeysTable.Padding = new System.Windows.Forms.Padding(16);
            this.aesKeysTable.RowCount = 2;
            this.aesKeysTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aesKeysTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aesKeysTable.Size = new System.Drawing.Size(1156, 594);
            this.aesKeysTable.TabIndex = 1;
            // 
            // AesKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.aesKeysTable);
            this.Controls.Add(this.Title);
            this.Name = "AesKeys";
            this.Size = new System.Drawing.Size(1156, 635);
            this.Load += new System.EventHandler(this.AesKeys_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TableLayoutPanel aesKeysTable;
    }
}
