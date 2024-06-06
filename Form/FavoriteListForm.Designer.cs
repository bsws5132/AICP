namespace SPOAICP
{
    partial class FavoriteListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteListForm));
            this.AlbumInfoLabel = new System.Windows.Forms.Label();
            this.FavoriteListbox = new System.Windows.Forms.ListBox();
            this.pbxAlbumImage = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메인화면으로돌아가기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbumImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlbumInfoLabel
            // 
            this.AlbumInfoLabel.AutoSize = true;
            this.AlbumInfoLabel.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.AlbumInfoLabel.Location = new System.Drawing.Point(676, 362);
            this.AlbumInfoLabel.Name = "AlbumInfoLabel";
            this.AlbumInfoLabel.Size = new System.Drawing.Size(180, 20);
            this.AlbumInfoLabel.TabIndex = 0;
            this.AlbumInfoLabel.Text = "여기에 해당 곡의 정보";
            // 
            // FavoriteListbox
            // 
            this.FavoriteListbox.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.FavoriteListbox.FormattingEnabled = true;
            this.FavoriteListbox.ItemHeight = 20;
            this.FavoriteListbox.Location = new System.Drawing.Point(164, 98);
            this.FavoriteListbox.Name = "FavoriteListbox";
            this.FavoriteListbox.ScrollAlwaysVisible = true;
            this.FavoriteListbox.Size = new System.Drawing.Size(262, 444);
            this.FavoriteListbox.TabIndex = 1;
            // 
            // pbxAlbumImage
            // 
            this.pbxAlbumImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxAlbumImage.Image")));
            this.pbxAlbumImage.Location = new System.Drawing.Point(619, 35);
            this.pbxAlbumImage.Name = "pbxAlbumImage";
            this.pbxAlbumImage.Size = new System.Drawing.Size(300, 300);
            this.pbxAlbumImage.TabIndex = 2;
            this.pbxAlbumImage.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.TitleLabel.Location = new System.Drawing.Point(169, 75);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(122, 20);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "즐겨찾기 목록 ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인화면으로돌아가기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인화면으로돌아가기ToolStripMenuItem
            // 
            this.메인화면으로돌아가기ToolStripMenuItem.Name = "메인화면으로돌아가기ToolStripMenuItem";
            this.메인화면으로돌아가기ToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.메인화면으로돌아가기ToolStripMenuItem.Text = "메인 화면으로 돌아가기";
            this.메인화면으로돌아가기ToolStripMenuItem.Click += new System.EventHandler(this.메인화면으로돌아가기ToolStripMenuItem_Click);
            // 
            // FavoriteListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 579);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.pbxAlbumImage);
            this.Controls.Add(this.FavoriteListbox);
            this.Controls.Add(this.AlbumInfoLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FavoriteListForm";
            this.Text = "FavoriteListForm";
            this.Load += new System.EventHandler(this.FavoriteListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbumImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlbumInfoLabel;
        private System.Windows.Forms.ListBox FavoriteListbox;
        private System.Windows.Forms.PictureBox pbxAlbumImage;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메인화면으로돌아가기ToolStripMenuItem;
    }
}