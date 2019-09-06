namespace doubleEncryption
{
    partial class FormDecryption
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
            this.encryptionTxt = new System.Windows.Forms.TextBox();
            this.decryptionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyDeL = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultDeL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptionTxt
            // 
            this.encryptionTxt.Location = new System.Drawing.Point(14, 52);
            this.encryptionTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptionTxt.Name = "encryptionTxt";
            this.encryptionTxt.Size = new System.Drawing.Size(349, 25);
            this.encryptionTxt.TabIndex = 0;
            // 
            // decryptionBtn
            // 
            this.decryptionBtn.Location = new System.Drawing.Point(16, 252);
            this.decryptionBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decryptionBtn.Name = "decryptionBtn";
            this.decryptionBtn.Size = new System.Drawing.Size(86, 29);
            this.decryptionBtn.TabIndex = 1;
            this.decryptionBtn.Text = "복호화";
            this.decryptionBtn.UseVisualStyleBackColor = true;
            this.decryptionBtn.Click += new System.EventHandler(this.decryptionBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "암호문";
            // 
            // keyDeL
            // 
            this.keyDeL.AutoSize = true;
            this.keyDeL.Location = new System.Drawing.Point(11, 110);
            this.keyDeL.Name = "keyDeL";
            this.keyDeL.Size = new System.Drawing.Size(52, 15);
            this.keyDeL.TabIndex = 4;
            this.keyDeL.Text = "암호키";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 25);
            this.textBox1.TabIndex = 5;
            // 
            // resultDeL
            // 
            this.resultDeL.AutoSize = true;
            this.resultDeL.Location = new System.Drawing.Point(14, 179);
            this.resultDeL.Name = "resultDeL";
            this.resultDeL.Size = new System.Drawing.Size(52, 15);
            this.resultDeL.TabIndex = 6;
            this.resultDeL.Text = "결과값";
            // 
            // FormDecryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 292);
            this.Controls.Add(this.resultDeL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.keyDeL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptionBtn);
            this.Controls.Add(this.encryptionTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDecryption";
            this.Text = "복호화";
            this.Load += new System.EventHandler(this.FormDecryption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encryptionTxt;
        private System.Windows.Forms.Button decryptionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label keyDeL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label resultDeL;
    }
}