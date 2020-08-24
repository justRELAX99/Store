namespace Store_kurs
{
    partial class RegForm
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
            this.pass_lbl = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.login_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondName_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(144, 12);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(100, 20);
            this.login_tb.TabIndex = 6;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(144, 49);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(100, 20);
            this.password_tb.TabIndex = 7;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(144, 180);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(100, 23);
            this.login_btn.TabIndex = 11;
            this.login_btn.Text = "BACK TO LOG IN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Location = new System.Drawing.Point(68, 49);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(70, 13);
            this.pass_lbl.TabIndex = 9;
            this.pass_lbl.Text = "PASSWORD";
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(144, 151);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(100, 23);
            this.reg_btn.TabIndex = 10;
            this.reg_btn.Text = "SIGN UP";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(98, 12);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(40, 13);
            this.login_lbl.TabIndex = 8;
            this.login_lbl.Text = "LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "SECOND NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "NAME";
            // 
            // secondName_tb
            // 
            this.secondName_tb.Location = new System.Drawing.Point(144, 122);
            this.secondName_tb.Name = "secondName_tb";
            this.secondName_tb.Size = new System.Drawing.Size(100, 20);
            this.secondName_tb.TabIndex = 13;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(144, 85);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 20);
            this.name_tb.TabIndex = 12;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondName_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondName_tb;
        private System.Windows.Forms.TextBox name_tb;
    }
}