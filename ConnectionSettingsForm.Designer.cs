namespace Store_kurs
{
    partial class ConnectionSettingsForm
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
            this.dataSource_lbl = new System.Windows.Forms.Label();
            this.dataSource_tb = new System.Windows.Forms.TextBox();
            this.nameDataBase_tb = new System.Windows.Forms.TextBox();
            this.nameDataBase_lbl = new System.Windows.Forms.Label();
            this.userName_tb = new System.Windows.Forms.TextBox();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.saveConnectionSettings_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataSource_lbl
            // 
            this.dataSource_lbl.AutoSize = true;
            this.dataSource_lbl.Location = new System.Drawing.Point(12, 9);
            this.dataSource_lbl.Name = "dataSource_lbl";
            this.dataSource_lbl.Size = new System.Drawing.Size(84, 13);
            this.dataSource_lbl.TabIndex = 0;
            this.dataSource_lbl.Text = "DATA SOURCE";
            // 
            // dataSource_tb
            // 
            this.dataSource_tb.Location = new System.Drawing.Point(119, 6);
            this.dataSource_tb.Name = "dataSource_tb";
            this.dataSource_tb.Size = new System.Drawing.Size(100, 20);
            this.dataSource_tb.TabIndex = 1;
            // 
            // nameDataBase_tb
            // 
            this.nameDataBase_tb.Location = new System.Drawing.Point(119, 32);
            this.nameDataBase_tb.Name = "nameDataBase_tb";
            this.nameDataBase_tb.Size = new System.Drawing.Size(100, 20);
            this.nameDataBase_tb.TabIndex = 3;
            // 
            // nameDataBase_lbl
            // 
            this.nameDataBase_lbl.AutoSize = true;
            this.nameDataBase_lbl.Location = new System.Drawing.Point(12, 35);
            this.nameDataBase_lbl.Name = "nameDataBase_lbl";
            this.nameDataBase_lbl.Size = new System.Drawing.Size(101, 13);
            this.nameDataBase_lbl.TabIndex = 2;
            this.nameDataBase_lbl.Text = "NAME DATA BASE";
            // 
            // userName_tb
            // 
            this.userName_tb.Location = new System.Drawing.Point(119, 58);
            this.userName_tb.Name = "userName_tb";
            this.userName_tb.Size = new System.Drawing.Size(100, 20);
            this.userName_tb.TabIndex = 5;
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Location = new System.Drawing.Point(12, 61);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(71, 13);
            this.userName_lbl.TabIndex = 4;
            this.userName_lbl.Text = "USER NAME";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(119, 84);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(100, 20);
            this.password_tb.TabIndex = 7;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(12, 87);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(70, 13);
            this.password_lbl.TabIndex = 6;
            this.password_lbl.Text = "PASSWORD";
            // 
            // saveConnectionSettings_btn
            // 
            this.saveConnectionSettings_btn.Location = new System.Drawing.Point(12, 165);
            this.saveConnectionSettings_btn.Name = "saveConnectionSettings_btn";
            this.saveConnectionSettings_btn.Size = new System.Drawing.Size(135, 23);
            this.saveConnectionSettings_btn.TabIndex = 8;
            this.saveConnectionSettings_btn.Text = "SAVE";
            this.saveConnectionSettings_btn.UseVisualStyleBackColor = true;
            this.saveConnectionSettings_btn.Click += new System.EventHandler(this.saveConnectionSettings_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(237, 165);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(135, 23);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // ConnectionSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.saveConnectionSettings_btn);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.userName_tb);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.nameDataBase_tb);
            this.Controls.Add(this.nameDataBase_lbl);
            this.Controls.Add(this.dataSource_tb);
            this.Controls.Add(this.dataSource_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataSource_lbl;
        private System.Windows.Forms.TextBox dataSource_tb;
        private System.Windows.Forms.TextBox nameDataBase_tb;
        private System.Windows.Forms.Label nameDataBase_lbl;
        private System.Windows.Forms.TextBox userName_tb;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button saveConnectionSettings_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}