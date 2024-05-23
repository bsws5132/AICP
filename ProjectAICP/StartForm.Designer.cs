namespace ProjectAICP
{
    partial class StartForm
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
            this.RecommandButton = new System.Windows.Forms.Button();
            this.BPM_Textbox = new System.Windows.Forms.TextBox();
            this.Genre_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FavoriteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecommandButton
            // 
            this.RecommandButton.Font = new System.Drawing.Font("경기천년제목 Medium", 14F);
            this.RecommandButton.Location = new System.Drawing.Point(239, 364);
            this.RecommandButton.Name = "RecommandButton";
            this.RecommandButton.Size = new System.Drawing.Size(150, 30);
            this.RecommandButton.TabIndex = 0;
            this.RecommandButton.Text = "Recommand";
            this.RecommandButton.UseVisualStyleBackColor = true;
            this.RecommandButton.Click += new System.EventHandler(this.RecommandButton_Click);
            // 
            // BPM_Textbox
            // 
            this.BPM_Textbox.Location = new System.Drawing.Point(424, 110);
            this.BPM_Textbox.Name = "BPM_Textbox";
            this.BPM_Textbox.Size = new System.Drawing.Size(170, 21);
            this.BPM_Textbox.TabIndex = 1;
            // 
            // Genre_TextBox
            // 
            this.Genre_TextBox.Location = new System.Drawing.Point(424, 214);
            this.Genre_TextBox.Name = "Genre_TextBox";
            this.Genre_TextBox.Size = new System.Drawing.Size(170, 21);
            this.Genre_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목 Medium", 10F);
            this.label1.Location = new System.Drawing.Point(600, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "BPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("경기천년제목 Medium", 10F);
            this.label2.Location = new System.Drawing.Point(275, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "GENRE 입력";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("경기천년제목 Medium", 10F);
            this.label3.Location = new System.Drawing.Point(275, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "BPM 입력";
            // 
            // FavoriteButton
            // 
            this.FavoriteButton.Font = new System.Drawing.Font("경기천년제목 Medium", 14F);
            this.FavoriteButton.Location = new System.Drawing.Point(485, 364);
            this.FavoriteButton.Name = "FavoriteButton";
            this.FavoriteButton.Size = new System.Drawing.Size(150, 30);
            this.FavoriteButton.TabIndex = 6;
            this.FavoriteButton.Text = "Favorite";
            this.FavoriteButton.UseVisualStyleBackColor = true;
            this.FavoriteButton.Click += new System.EventHandler(this.FavoriteButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 461);
            this.Controls.Add(this.FavoriteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Genre_TextBox);
            this.Controls.Add(this.BPM_Textbox);
            this.Controls.Add(this.RecommandButton);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RecommandButton;
        private System.Windows.Forms.TextBox BPM_Textbox;
        private System.Windows.Forms.TextBox Genre_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FavoriteButton;
    }
}

