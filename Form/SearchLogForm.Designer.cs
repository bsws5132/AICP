namespace SPOAICP
{
    partial class SearchLogForm
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
            this.AddFavoriteButton = new System.Windows.Forms.Button();
            this.AlbumInfoLabel = new System.Windows.Forms.Label();
            this.pbxAlbumImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메인메뉴로돌아가기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbumImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFavoriteButton
            // 
            this.AddFavoriteButton.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.AddFavoriteButton.Location = new System.Drawing.Point(483, 400);
            this.AddFavoriteButton.Name = "AddFavoriteButton";
            this.AddFavoriteButton.Size = new System.Drawing.Size(132, 70);
            this.AddFavoriteButton.TabIndex = 8;
            this.AddFavoriteButton.Text = "즐겨찾기 버튼";
            this.AddFavoriteButton.UseVisualStyleBackColor = true;
            // 
            // AlbumInfoLabel
            // 
            this.AlbumInfoLabel.AutoSize = true;
            this.AlbumInfoLabel.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.AlbumInfoLabel.Location = new System.Drawing.Point(774, 94);
            this.AlbumInfoLabel.Name = "AlbumInfoLabel";
            this.AlbumInfoLabel.Size = new System.Drawing.Size(180, 20);
            this.AlbumInfoLabel.TabIndex = 6;
            this.AlbumInfoLabel.Text = "여기에 해당 곡의 정보";
            // 
            // pbxAlbumImage
            // 
            this.pbxAlbumImage.Image = global::SPOAICP.Properties.Resources.SAMPLEIMAGE2;
            this.pbxAlbumImage.Location = new System.Drawing.Point(395, 94);
            this.pbxAlbumImage.Name = "pbxAlbumImage";
            this.pbxAlbumImage.Size = new System.Drawing.Size(300, 300);
            this.pbxAlbumImage.TabIndex = 7;
            this.pbxAlbumImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인메뉴로돌아가기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인메뉴로돌아가기ToolStripMenuItem
            // 
            this.메인메뉴로돌아가기ToolStripMenuItem.Name = "메인메뉴로돌아가기ToolStripMenuItem";
            this.메인메뉴로돌아가기ToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.메인메뉴로돌아가기ToolStripMenuItem.Text = "메인 메뉴로 돌아가기";
            this.메인메뉴로돌아가기ToolStripMenuItem.Click += new System.EventHandler(this.메인메뉴로돌아가기ToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(274, 384);
            this.listBox1.TabIndex = 10;
            // 
            // SearchLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 572);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddFavoriteButton);
            this.Controls.Add(this.pbxAlbumImage);
            this.Controls.Add(this.AlbumInfoLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchLogForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbumImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFavoriteButton;
        private System.Windows.Forms.PictureBox pbxAlbumImage;
        private System.Windows.Forms.Label AlbumInfoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메인메뉴로돌아가기ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}