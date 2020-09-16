namespace Store_kurs
{
    partial class AuthForm
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
            this.login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.connectionSettings_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(144, 72);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(100, 20);
            this.login_tb.TabIndex = 0;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(144, 109);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(100, 20);
            this.password_tb.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(144, 151);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(100, 23);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "LOG IN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(144, 180);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(100, 23);
            this.reg_btn.TabIndex = 3;
            this.reg_btn.Text = "SIGN UP";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(70, 72);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(68, 13);
            this.login_lbl.TabIndex = 4;
            this.login_lbl.Text = "USERNAME";
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Location = new System.Drawing.Point(70, 109);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(70, 13);
            this.pass_lbl.TabIndex = 5;
            this.pass_lbl.Text = "PASSWORD";
            // 
            // connectionSettings_btn
            // 
            this.connectionSettings_btn.Location = new System.Drawing.Point(250, 151);
            this.connectionSettings_btn.Name = "connectionSettings_btn";
            this.connectionSettings_btn.Size = new System.Drawing.Size(122, 52);
            this.connectionSettings_btn.TabIndex = 6;
            this.connectionSettings_btn.Text = "CONNECTION SETTINGS";
            this.connectionSettings_btn.UseVisualStyleBackColor = true;
            this.connectionSettings_btn.Click += new System.EventHandler(this.connectionSettings_btn_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.connectionSettings_btn);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Button connectionSettings_btn;
    }
}