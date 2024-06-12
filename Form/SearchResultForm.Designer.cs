namespace SPOAICP
{
    partial class SearchResultForm
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
            this.pbxAlbumImage = new System.Windows.Forms.PictureBox();
            this.AlbumInfoLabel = new System.Windows.Forms.Label();
            this.AddFavoriteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메인화면으로돌아가기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbumImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxAlbumImage
            // 
            this.pbxAlbumImage.Image = global::SPOAICP.Properties.Resources.SAMPLEIMAGE2;
            this.pbxAlbumImage.Location = new System.Drawing.Point(66, 148);
            this.pbxAlbumImage.Name = "pbxAlbumImage";
            this.pbxAlbumImage.Size = new System.Drawing.Size(300, 300);
            this.pbxAlbumImage.TabIndex = 4;
            this.pbxAlbumImage.TabStop = false;
            // 
            // AlbumInfoLabel
            // 
            this.AlbumInfoLabel.AutoSize = true;
            this.AlbumInfoLabel.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.AlbumInfoLabel.Location = new System.Drawing.Point(420, 148);
            this.AlbumInfoLabel.Name = "AlbumInfoLabel";
            this.AlbumInfoLabel.Size = new System.Drawing.Size(180, 20);
            this.AlbumInfoLabel.TabIndex = 3;
            this.AlbumInfoLabel.Text = "여기에 해당 곡의 정보";
            // 
            // AddFavoriteButton
            // 
            this.AddFavoriteButton.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.AddFavoriteButton.Location = new System.Drawing.Point(301, 148);
            this.AddFavoriteButton.Name = "AddFavoriteButton";
            this.AddFavoriteButton.Size = new System.Drawing.Size(65, 52);
            this.AddFavoriteButton.TabIndex = 5;
            this.AddFavoriteButton.Text = "즐겨찾기 버튼";
            this.AddFavoriteButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인화면으로돌아가기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인화면으로돌아가기ToolStripMenuItem
            // 
            this.메인화면으로돌아가기ToolStripMenuItem.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.메인화면으로돌아가기ToolStripMenuItem.Name = "메인화면으로돌아가기ToolStripMenuItem";
            this.메인화면으로돌아가기ToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.메인화면으로돌아가기ToolStripMenuItem.Text = "메인 화면으로 돌아가기";
            this.메인화면으로돌아가기ToolStripMenuItem.Click += new System.EventHandler(this.메인화면으로돌아가기ToolStripMenuItem_Click);
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 522);
            this.Controls.Add(this.AddFavoriteButton);
            this.Controls.Add(this.pbxAlbumImage);
            this.Controls.Add(this.AlbumInfoLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchResultForm";
            this.Text = "SearchResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbumImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAlbumImage;
        private System.Windows.Forms.Label AlbumInfoLabel;
        private System.Windows.Forms.Button AddFavoriteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메인화면으로돌아가기ToolStripMenuItem;
    }
}