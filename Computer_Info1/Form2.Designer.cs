namespace Computer_Info1
{
    partial class Form2
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.txtBox_domainName = new System.Windows.Forms.TextBox();
            this.lbl_domainName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(12, 37);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(57, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "UserName";
            this.lbl_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 63);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 86);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(132, 86);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txtBox_username
            // 
            this.txtBox_username.Location = new System.Drawing.Point(82, 34);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(125, 20);
            this.txtBox_username.TabIndex = 4;
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(82, 60);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(125, 20);
            this.txtBox_password.TabIndex = 5;
            // 
            // txtBox_domainName
            // 
            this.txtBox_domainName.Location = new System.Drawing.Point(82, 8);
            this.txtBox_domainName.Name = "txtBox_domainName";
            this.txtBox_domainName.Size = new System.Drawing.Size(125, 20);
            this.txtBox_domainName.TabIndex = 6;
            
            // 
            // lbl_domainName
            // 
            this.lbl_domainName.AutoSize = true;
            this.lbl_domainName.Location = new System.Drawing.Point(12, 11);
            this.lbl_domainName.Name = "lbl_domainName";
            this.lbl_domainName.Size = new System.Drawing.Size(71, 13);
            this.lbl_domainName.TabIndex = 7;
            this.lbl_domainName.Text = "DomainName";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 121);
            this.Controls.Add(this.lbl_domainName);
            this.Controls.Add(this.txtBox_domainName);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.txtBox_username);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "Form2";
            this.Text = "Credentials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.TextBox txtBox_domainName;
        private System.Windows.Forms.Label lbl_domainName;
    }
}