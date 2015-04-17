namespace Population_X.Forms.EncryptionTest
{
    partial class frmEncryptionDecryptionTest
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
            this.tbStringToEncrypt = new System.Windows.Forms.TextBox();
            this.tbEncryptedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDecryptedText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncryptTest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbEncryptedBytes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to Encrypt";
            // 
            // tbStringToEncrypt
            // 
            this.tbStringToEncrypt.Location = new System.Drawing.Point(13, 30);
            this.tbStringToEncrypt.Name = "tbStringToEncrypt";
            this.tbStringToEncrypt.Size = new System.Drawing.Size(386, 20);
            this.tbStringToEncrypt.TabIndex = 0;
            // 
            // tbEncryptedText
            // 
            this.tbEncryptedText.Location = new System.Drawing.Point(13, 70);
            this.tbEncryptedText.Name = "tbEncryptedText";
            this.tbEncryptedText.Size = new System.Drawing.Size(386, 20);
            this.tbEncryptedText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted String";
            // 
            // tbDecryptedText
            // 
            this.tbDecryptedText.Location = new System.Drawing.Point(13, 150);
            this.tbDecryptedText.Name = "tbDecryptedText";
            this.tbDecryptedText.ReadOnly = true;
            this.tbDecryptedText.Size = new System.Drawing.Size(386, 20);
            this.tbDecryptedText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decrypted Result";
            // 
            // btnEncryptTest
            // 
            this.btnEncryptTest.Location = new System.Drawing.Point(301, 176);
            this.btnEncryptTest.Name = "btnEncryptTest";
            this.btnEncryptTest.Size = new System.Drawing.Size(98, 23);
            this.btnEncryptTest.TabIndex = 1;
            this.btnEncryptTest.Text = "Test Encryption";
            this.btnEncryptTest.UseVisualStyleBackColor = true;
            this.btnEncryptTest.Click += new System.EventHandler(this.btnEncryptTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbEncryptedBytes
            // 
            this.tbEncryptedBytes.Location = new System.Drawing.Point(13, 110);
            this.tbEncryptedBytes.Name = "tbEncryptedBytes";
            this.tbEncryptedBytes.Size = new System.Drawing.Size(386, 20);
            this.tbEncryptedBytes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Encrypted Bytes";
            // 
            // frmEncryptionDecryptionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 215);
            this.Controls.Add(this.tbEncryptedBytes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEncryptTest);
            this.Controls.Add(this.tbDecryptedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEncryptedText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStringToEncrypt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEncryptionDecryptionTest";
            this.Text = "frmEncryptionDecryptionTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStringToEncrypt;
        private System.Windows.Forms.TextBox tbEncryptedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDecryptedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncryptTest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbEncryptedBytes;
        private System.Windows.Forms.Label label4;
    }
}