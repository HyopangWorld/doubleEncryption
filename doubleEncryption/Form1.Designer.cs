namespace doubleEncryption
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.startEnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startDeBtn = new System.Windows.Forms.Button();
            this.overBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startEnBtn
            // 
            this.startEnBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startEnBtn.Location = new System.Drawing.Point(44, 130);
            this.startEnBtn.Name = "startEnBtn";
            this.startEnBtn.Size = new System.Drawing.Size(90, 27);
            this.startEnBtn.TabIndex = 1;
            this.startEnBtn.Text = "암호화";
            this.startEnBtn.UseVisualStyleBackColor = true;
            this.startEnBtn.Click += new System.EventHandler(this.encryptionBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "EncryptionProgram";
            // 
            // startDeBtn
            // 
            this.startDeBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startDeBtn.Location = new System.Drawing.Point(188, 130);
            this.startDeBtn.Name = "startDeBtn";
            this.startDeBtn.Size = new System.Drawing.Size(101, 27);
            this.startDeBtn.TabIndex = 1;
            this.startDeBtn.Text = "복호화";
            this.startDeBtn.UseVisualStyleBackColor = true;
            this.startDeBtn.Click += new System.EventHandler(this.decyptionBtn_Click);
            // 
            // overBtn
            // 
            this.overBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.overBtn.Location = new System.Drawing.Point(122, 182);
            this.overBtn.Name = "overBtn";
            this.overBtn.Size = new System.Drawing.Size(75, 23);
            this.overBtn.TabIndex = 3;
            this.overBtn.Text = "종료";
            this.overBtn.UseVisualStyleBackColor = true;
            this.overBtn.Click += new System.EventHandler(this.overBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 229);
            this.Controls.Add(this.overBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDeBtn);
            this.Controls.Add(this.startEnBtn);
            this.Name = "Form1";
            this.Text = "암호프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startEnBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startDeBtn;
        private System.Windows.Forms.Button overBtn;
    }
}

