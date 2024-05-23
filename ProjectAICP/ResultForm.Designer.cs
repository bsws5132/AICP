namespace ProjectAICP
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BPM_label = new System.Windows.Forms.Label();
            this.Genre_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력하신 정보와 유사한 곡을 찾았습니다.";
            // 
            // BPM_label
            // 
            this.BPM_label.AutoSize = true;
            this.BPM_label.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.BPM_label.Location = new System.Drawing.Point(34, 84);
            this.BPM_label.Name = "BPM_label";
            this.BPM_label.Size = new System.Drawing.Size(95, 20);
            this.BPM_label.TabIndex = 1;
            this.BPM_label.Text = "BPM : %d";
            // 
            // Genre_label
            // 
            this.Genre_label.AutoSize = true;
            this.Genre_label.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.Genre_label.Location = new System.Drawing.Point(163, 84);
            this.Genre_label.Name = "Genre_label";
            this.Genre_label.Size = new System.Drawing.Size(109, 20);
            this.Genre_label.TabIndex = 2;
            this.Genre_label.Text = "Genre : %d";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(167, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 288);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(774, 100);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 341);
            this.vScrollBar1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.button1.Location = new System.Drawing.Point(621, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "즐겨찾기 등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("경기천년제목 Medium", 15F);
            this.label4.Location = new System.Drawing.Point(491, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "BPM : %d";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Genre_label);
            this.Controls.Add(this.BPM_label);
            this.Controls.Add(this.label1);
            this.Name = "ResultForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BPM_label;
        private System.Windows.Forms.Label Genre_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}