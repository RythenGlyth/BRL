namespace FTool
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.FormLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.newsButton = new System.Windows.Forms.Button();
            this.aesKeyIcon = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.storeButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.newsPanel = new System.Windows.Forms.Panel();
            this.newsLabel = new System.Windows.Forms.Label();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.aesKeyPanel = new System.Windows.Forms.Panel();
            this.aesKeyLabel = new System.Windows.Forms.Label();
            this.storePanel = new System.Windows.Forms.Panel();
            this.storeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.aesKeys1 = new FTool.Pages.AesKeys();
            this.itemShop1 = new FTool.Pages.ItemShop();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.PanelSlide.SuspendLayout();
            this.newsPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.aesKeyPanel.SuspendLayout();
            this.storePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.closeWindowButton);
            this.HeaderPanel.Controls.Add(this.FormLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1198, 40);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeWindowButton.FlatAppearance.BorderSize = 0;
            this.closeWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("closeWindowButton.Image")));
            this.closeWindowButton.Location = new System.Drawing.Point(1155, 1);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(42, 39);
            this.closeWindowButton.TabIndex = 4;
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Burbank Big Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.Location = new System.Drawing.Point(38, 2);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(69, 36);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "FTool";
            this.FormLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            this.FormLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MenuPanel.Controls.Add(this.newsButton);
            this.MenuPanel.Controls.Add(this.aesKeyIcon);
            this.MenuPanel.Controls.Add(this.aboutButton);
            this.MenuPanel.Controls.Add(this.settingsButton);
            this.MenuPanel.Controls.Add(this.storeButton);
            this.MenuPanel.Controls.Add(this.menuButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 40);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(44, 633);
            this.MenuPanel.TabIndex = 1;
            // 
            // newsButton
            // 
            this.newsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.newsButton.FlatAppearance.BorderSize = 0;
            this.newsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsButton.Image = ((System.Drawing.Image)(resources.GetObject("newsButton.Image")));
            this.newsButton.Location = new System.Drawing.Point(1, 121);
            this.newsButton.Name = "newsButton";
            this.newsButton.Size = new System.Drawing.Size(43, 34);
            this.newsButton.TabIndex = 5;
            this.newsButton.UseVisualStyleBackColor = false;
            this.newsButton.Click += new System.EventHandler(this.newsButton_Click);
            // 
            // aesKeyIcon
            // 
            this.aesKeyIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.aesKeyIcon.FlatAppearance.BorderSize = 0;
            this.aesKeyIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aesKeyIcon.Image = ((System.Drawing.Image)(resources.GetObject("aesKeyIcon.Image")));
            this.aesKeyIcon.Location = new System.Drawing.Point(1, 81);
            this.aesKeyIcon.Name = "aesKeyIcon";
            this.aesKeyIcon.Size = new System.Drawing.Size(43, 34);
            this.aesKeyIcon.TabIndex = 4;
            this.aesKeyIcon.UseVisualStyleBackColor = false;
            this.aesKeyIcon.Click += new System.EventHandler(this.aesKeyButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.Location = new System.Drawing.Point(1, 557);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(43, 34);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(1, 597);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(43, 34);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // storeButton
            // 
            this.storeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.storeButton.FlatAppearance.BorderSize = 0;
            this.storeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeButton.Image = ((System.Drawing.Image)(resources.GetObject("storeButton.Image")));
            this.storeButton.Location = new System.Drawing.Point(1, 41);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(43, 34);
            this.storeButton.TabIndex = 1;
            this.storeButton.UseVisualStyleBackColor = false;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(1, 1);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(43, 34);
            this.menuButton.TabIndex = 0;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // PanelSlide
            // 
            this.PanelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PanelSlide.Controls.Add(this.newsPanel);
            this.PanelSlide.Controls.Add(this.aboutPanel);
            this.PanelSlide.Controls.Add(this.settingsPanel);
            this.PanelSlide.Controls.Add(this.aesKeyPanel);
            this.PanelSlide.Controls.Add(this.storePanel);
            this.PanelSlide.Controls.Add(this.panel1);
            this.PanelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSlide.Location = new System.Drawing.Point(44, 40);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Size = new System.Drawing.Size(189, 633);
            this.PanelSlide.TabIndex = 2;
            // 
            // newsPanel
            // 
            this.newsPanel.Controls.Add(this.newsLabel);
            this.newsPanel.Location = new System.Drawing.Point(0, 121);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(222, 34);
            this.newsPanel.TabIndex = 4;
            this.newsPanel.Click += new System.EventHandler(this.newsButton_Click);
            // 
            // newsLabel
            // 
            this.newsLabel.AutoSize = true;
            this.newsLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.newsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLabel.Location = new System.Drawing.Point(6, 4);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Size = new System.Drawing.Size(127, 24);
            this.newsLabel.TabIndex = 0;
            this.newsLabel.Text = "Ingame-News";
            this.newsLabel.Click += new System.EventHandler(this.newsButton_Click);
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.aboutLabel);
            this.aboutPanel.Location = new System.Drawing.Point(0, 559);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(222, 34);
            this.aboutPanel.TabIndex = 5;
            this.aboutPanel.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(6, 4);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(60, 24);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "About";
            this.aboutLabel.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Location = new System.Drawing.Point(0, 599);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(222, 34);
            this.settingsPanel.TabIndex = 4;
            this.settingsPanel.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(6, 4);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(76, 24);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // aesKeyPanel
            // 
            this.aesKeyPanel.Controls.Add(this.aesKeyLabel);
            this.aesKeyPanel.Location = new System.Drawing.Point(0, 81);
            this.aesKeyPanel.Name = "aesKeyPanel";
            this.aesKeyPanel.Size = new System.Drawing.Size(222, 34);
            this.aesKeyPanel.TabIndex = 3;
            this.aesKeyPanel.Click += new System.EventHandler(this.aesKeyButton_Click);
            // 
            // aesKeyLabel
            // 
            this.aesKeyLabel.AutoSize = true;
            this.aesKeyLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.aesKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aesKeyLabel.Location = new System.Drawing.Point(6, 4);
            this.aesKeyLabel.Name = "aesKeyLabel";
            this.aesKeyLabel.Size = new System.Drawing.Size(80, 24);
            this.aesKeyLabel.TabIndex = 0;
            this.aesKeyLabel.Text = "Aes Key";
            this.aesKeyLabel.Click += new System.EventHandler(this.aesKeyButton_Click);
            // 
            // storePanel
            // 
            this.storePanel.Controls.Add(this.storeLabel);
            this.storePanel.Location = new System.Drawing.Point(0, 41);
            this.storePanel.Name = "storePanel";
            this.storePanel.Size = new System.Drawing.Size(222, 34);
            this.storePanel.TabIndex = 2;
            this.storePanel.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.Location = new System.Drawing.Point(6, 4);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(90, 24);
            this.storeLabel.TabIndex = 0;
            this.storeLabel.Text = "ItemShop";
            this.storeLabel.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 35);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(6, 4);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(66, 25);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Menu";
            this.menuLabel.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.aesKeys1);
            this.PanelContent.Controls.Add(this.itemShop1);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(233, 40);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(965, 633);
            this.PanelContent.TabIndex = 3;
            // 
            // aesKeys1
            // 
            this.aesKeys1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.aesKeys1.Location = new System.Drawing.Point(0, 0);
            this.aesKeys1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aesKeys1.Name = "aesKeys1";
            this.aesKeys1.Size = new System.Drawing.Size(1156, 635);
            this.aesKeys1.TabIndex = 1;
            // 
            // itemShop1
            // 
            this.itemShop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.itemShop1.Location = new System.Drawing.Point(0, 0);
            this.itemShop1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemShop1.Name = "itemShop1";
            this.itemShop1.Size = new System.Drawing.Size(1156, 635);
            this.itemShop1.TabIndex = 0;
            // 
            // mainpanel
            // 
            this.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainpanel.Controls.Add(this.PanelContent);
            this.mainpanel.Controls.Add(this.PanelSlide);
            this.mainpanel.Controls.Add(this.MenuPanel);
            this.mainpanel.Controls.Add(this.HeaderPanel);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1200, 675);
            this.mainpanel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.mainpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BRL";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.PanelSlide.ResumeLayout(false);
            this.newsPanel.ResumeLayout(false);
            this.newsPanel.PerformLayout();
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.aesKeyPanel.ResumeLayout(false);
            this.aesKeyPanel.PerformLayout();
            this.storePanel.ResumeLayout(false);
            this.storePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelContent.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel PanelSlide;
        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel storePanel;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.Button aesKeyIcon;
        private System.Windows.Forms.Panel aesKeyPanel;
        private System.Windows.Forms.Label aesKeyLabel;
        private Pages.ItemShop itemShop1;
        private Pages.AesKeys aesKeys1;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newsButton;
        private System.Windows.Forms.Panel newsPanel;
        private System.Windows.Forms.Label newsLabel;
    }
}

