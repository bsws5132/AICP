﻿namespace SPOAICP
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.즐겨찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.검색기록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.textBox1.Location = new System.Drawing.Point(271, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.textBox2.Location = new System.Drawing.Point(480, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 27);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.button1.Location = new System.Drawing.Point(350, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "정보 입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.label1.Location = new System.Drawing.Point(557, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.label2.Location = new System.Drawing.Point(309, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.label3.Location = new System.Drawing.Point(529, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "BPM";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.즐겨찾기ToolStripMenuItem,
            this.검색기록ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(20, 60);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(135, 370);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 즐겨찾기ToolStripMenuItem
            // 
            this.즐겨찾기ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.즐겨찾기ToolStripMenuItem.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.즐겨찾기ToolStripMenuItem.Name = "즐겨찾기ToolStripMenuItem";
            this.즐겨찾기ToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.즐겨찾기ToolStripMenuItem.Text = "즐겨찾기 목록";
            this.즐겨찾기ToolStripMenuItem.Click += new System.EventHandler(this.즐겨찾기ToolStripMenuItem_Click);
            // 
            // 검색기록ToolStripMenuItem
            // 
            this.검색기록ToolStripMenuItem.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.검색기록ToolStripMenuItem.Name = "검색기록ToolStripMenuItem";
            this.검색기록ToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.검색기록ToolStripMenuItem.Text = "검색 기록";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "APICP";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 검색기록ToolStripMenuItem;
    }
}

