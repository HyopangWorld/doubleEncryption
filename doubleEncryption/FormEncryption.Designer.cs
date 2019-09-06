namespace doubleEncryption
{
    partial class FormEncryption
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
            this.encryptionBtn = new System.Windows.Forms.Button();
            this.plainTxt = new System.Windows.Forms.TextBox();
            this.keyEnTxt = new System.Windows.Forms.TextBox();
            this.plainL = new System.Windows.Forms.Label();
            this.keyEnL = new System.Windows.Forms.Label();
            this.resultEnL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptionBtn
            // 
            this.encryptionBtn.Location = new System.Drawing.Point(12, 285);
            this.encryptionBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptionBtn.Name = "encryptionBtn";
            this.encryptionBtn.Size = new System.Drawing.Size(86, 29);
            this.encryptionBtn.TabIndex = 0;
            this.encryptionBtn.Text = "암호화";
            this.encryptionBtn.UseVisualStyleBackColor = true;
            this.encryptionBtn.Click += new System.EventHandler(this.encryptionBtn_Click);
            // 
            // plainTxt
            // 
            this.plainTxt.Location = new System.Drawing.Point(14, 52);
            this.plainTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plainTxt.Name = "plainTxt";
            this.plainTxt.Size = new System.Drawing.Size(349, 25);
            this.plainTxt.TabIndex = 1;
            this.plainTxt.TextChanged += new System.EventHandler(this.plainTxt_TextChanged);
            // 
            // keyEnTxt
            // 
            this.keyEnTxt.Location = new System.Drawing.Point(14, 129);
            this.keyEnTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyEnTxt.Name = "keyEnTxt";
            this.keyEnTxt.Size = new System.Drawing.Size(349, 25);
            this.keyEnTxt.TabIndex = 2;
            // 
            // plainL
            // 
            this.plainL.AutoSize = true;
            this.plainL.Location = new System.Drawing.Point(14, 34);
            this.plainL.Name = "plainL";
            this.plainL.Size = new System.Drawing.Size(37, 15);
            this.plainL.TabIndex = 3;
            this.plainL.Text = "평문";
            // 
            // keyEnL
            // 
            this.keyEnL.AutoSize = true;
            this.keyEnL.Location = new System.Drawing.Point(11, 110);
            this.keyEnL.Name = "keyEnL";
            this.keyEnL.Size = new System.Drawing.Size(52, 15);
            this.keyEnL.TabIndex = 3;
            this.keyEnL.Text = "암호키";
            // 
            // resultEnL
            // 
            this.resultEnL.AutoSize = true;
            this.resultEnL.Location = new System.Drawing.Point(14, 179);
            this.resultEnL.Name = "resultEnL";
            this.resultEnL.Size = new System.Drawing.Size(52, 15);
            this.resultEnL.TabIndex = 4;
            this.resultEnL.Text = "결과값";
            // 
            // FormEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 327);
            this.Controls.Add(this.resultEnL);
            this.Controls.Add(this.keyEnL);
            this.Controls.Add(this.plainL);
            this.Controls.Add(this.keyEnTxt);
            this.Controls.Add(this.plainTxt);
            this.Controls.Add(this.encryptionBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEncryption";
            this.Text = "암호화";
            this.Load += new System.EventHandler(this.FormEncryption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptionBtn;
        private System.Windows.Forms.TextBox plainTxt;
        private System.Windows.Forms.TextBox keyEnTxt;
        private System.Windows.Forms.Label plainL;
        private System.Windows.Forms.Label keyEnL;
        private System.Windows.Forms.Label resultEnL;
    }
}