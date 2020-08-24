namespace Store_kurs
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userInfo_tp = new System.Windows.Forms.TabPage();
            this.createSaleCard_btn = new System.Windows.Forms.Button();
            this.saleCard_tb = new System.Windows.Forms.TextBox();
            this.saleCard_lbl = new System.Windows.Forms.Label();
            this.oldPassword_lbl = new System.Windows.Forms.Label();
            this.oldPassword_tb = new System.Windows.Forms.TextBox();
            this.confirmPassword_lbl = new System.Windows.Forms.Label();
            this.newPassword_lbl = new System.Windows.Forms.Label();
            this.confirmPassword_tb = new System.Windows.Forms.TextBox();
            this.newPassword_tb = new System.Windows.Forms.TextBox();
            this.cancelPassword_btn = new System.Windows.Forms.Button();
            this.savePassword_btn = new System.Windows.Forms.Button();
            this.changePassword_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.saveData_btn = new System.Windows.Forms.Button();
            this.changeData_btn = new System.Windows.Forms.Button();
            this.secondName_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.secondName_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.products_tp = new System.Windows.Forms.TabPage();
            this.addToBasket_btn = new System.Windows.Forms.Button();
            this.products_dgv = new System.Windows.Forms.DataGridView();
            this.basket_tp = new System.Windows.Forms.TabPage();
            this.deleteFromBasket_btn = new System.Windows.Forms.Button();
            this.basket_dgv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.userInfo_tp.SuspendLayout();
            this.products_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_dgv)).BeginInit();
            this.basket_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basket_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.userInfo_tp);
            this.tabControl1.Controls.Add(this.products_tp);
            this.tabControl1.Controls.Add(this.basket_tp);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 537);
            this.tabControl1.TabIndex = 1;
            // 
            // userInfo_tp
            // 
            this.userInfo_tp.Controls.Add(this.createSaleCard_btn);
            this.userInfo_tp.Controls.Add(this.saleCard_tb);
            this.userInfo_tp.Controls.Add(this.saleCard_lbl);
            this.userInfo_tp.Controls.Add(this.oldPassword_lbl);
            this.userInfo_tp.Controls.Add(this.oldPassword_tb);
            this.userInfo_tp.Controls.Add(this.confirmPassword_lbl);
            this.userInfo_tp.Controls.Add(this.newPassword_lbl);
            this.userInfo_tp.Controls.Add(this.confirmPassword_tb);
            this.userInfo_tp.Controls.Add(this.newPassword_tb);
            this.userInfo_tp.Controls.Add(this.cancelPassword_btn);
            this.userInfo_tp.Controls.Add(this.savePassword_btn);
            this.userInfo_tp.Controls.Add(this.changePassword_btn);
            this.userInfo_tp.Controls.Add(this.cancel_btn);
            this.userInfo_tp.Controls.Add(this.saveData_btn);
            this.userInfo_tp.Controls.Add(this.changeData_btn);
            this.userInfo_tp.Controls.Add(this.secondName_lbl);
            this.userInfo_tp.Controls.Add(this.name_lbl);
            this.userInfo_tp.Controls.Add(this.secondName_tb);
            this.userInfo_tp.Controls.Add(this.name_tb);
            this.userInfo_tp.Controls.Add(this.login_lbl);
            this.userInfo_tp.Controls.Add(this.login_tb);
            this.userInfo_tp.Location = new System.Drawing.Point(4, 22);
            this.userInfo_tp.Name = "userInfo_tp";
            this.userInfo_tp.Padding = new System.Windows.Forms.Padding(3);
            this.userInfo_tp.Size = new System.Drawing.Size(752, 511);
            this.userInfo_tp.TabIndex = 0;
            this.userInfo_tp.Text = "User";
            this.userInfo_tp.UseVisualStyleBackColor = true;
            // 
            // createSaleCard_btn
            // 
            this.createSaleCard_btn.Location = new System.Drawing.Point(403, 32);
            this.createSaleCard_btn.Name = "createSaleCard_btn";
            this.createSaleCard_btn.Size = new System.Drawing.Size(170, 23);
            this.createSaleCard_btn.TabIndex = 38;
            this.createSaleCard_btn.Text = "CREATE SALE CARD";
            this.createSaleCard_btn.UseVisualStyleBackColor = true;
            this.createSaleCard_btn.Visible = false;
            this.createSaleCard_btn.Click += new System.EventHandler(this.createSaleCard_btn_Click);
            // 
            // saleCard_tb
            // 
            this.saleCard_tb.Location = new System.Drawing.Point(473, 6);
            this.saleCard_tb.Name = "saleCard_tb";
            this.saleCard_tb.ReadOnly = true;
            this.saleCard_tb.Size = new System.Drawing.Size(100, 20);
            this.saleCard_tb.TabIndex = 37;
            // 
            // saleCard_lbl
            // 
            this.saleCard_lbl.AutoSize = true;
            this.saleCard_lbl.Location = new System.Drawing.Point(400, 6);
            this.saleCard_lbl.Name = "saleCard_lbl";
            this.saleCard_lbl.Size = new System.Drawing.Size(67, 13);
            this.saleCard_lbl.TabIndex = 36;
            this.saleCard_lbl.Text = "SALE CARD";
            // 
            // oldPassword_lbl
            // 
            this.oldPassword_lbl.AutoSize = true;
            this.oldPassword_lbl.Location = new System.Drawing.Point(115, 173);
            this.oldPassword_lbl.Name = "oldPassword_lbl";
            this.oldPassword_lbl.Size = new System.Drawing.Size(95, 13);
            this.oldPassword_lbl.TabIndex = 35;
            this.oldPassword_lbl.Text = "OLD PASSWORD";
            this.oldPassword_lbl.Visible = false;
            // 
            // oldPassword_tb
            // 
            this.oldPassword_tb.Location = new System.Drawing.Point(216, 173);
            this.oldPassword_tb.Name = "oldPassword_tb";
            this.oldPassword_tb.Size = new System.Drawing.Size(100, 20);
            this.oldPassword_tb.TabIndex = 34;
            this.oldPassword_tb.Visible = false;
            // 
            // confirmPassword_lbl
            // 
            this.confirmPassword_lbl.AutoSize = true;
            this.confirmPassword_lbl.Location = new System.Drawing.Point(88, 225);
            this.confirmPassword_lbl.Name = "confirmPassword_lbl";
            this.confirmPassword_lbl.Size = new System.Drawing.Size(122, 13);
            this.confirmPassword_lbl.TabIndex = 33;
            this.confirmPassword_lbl.Text = "CONFIRM PASSWORD";
            this.confirmPassword_lbl.Visible = false;
            // 
            // newPassword_lbl
            // 
            this.newPassword_lbl.AutoSize = true;
            this.newPassword_lbl.Location = new System.Drawing.Point(111, 199);
            this.newPassword_lbl.Name = "newPassword_lbl";
            this.newPassword_lbl.Size = new System.Drawing.Size(99, 13);
            this.newPassword_lbl.TabIndex = 32;
            this.newPassword_lbl.Text = "NEW PASSWORD";
            this.newPassword_lbl.Visible = false;
            // 
            // confirmPassword_tb
            // 
            this.confirmPassword_tb.Location = new System.Drawing.Point(216, 225);
            this.confirmPassword_tb.Name = "confirmPassword_tb";
            this.confirmPassword_tb.Size = new System.Drawing.Size(100, 20);
            this.confirmPassword_tb.TabIndex = 31;
            this.confirmPassword_tb.Visible = false;
            // 
            // newPassword_tb
            // 
            this.newPassword_tb.Location = new System.Drawing.Point(216, 199);
            this.newPassword_tb.Name = "newPassword_tb";
            this.newPassword_tb.Size = new System.Drawing.Size(100, 20);
            this.newPassword_tb.TabIndex = 30;
            this.newPassword_tb.Visible = false;
            // 
            // cancelPassword_btn
            // 
            this.cancelPassword_btn.Location = new System.Drawing.Point(216, 143);
            this.cancelPassword_btn.Name = "cancelPassword_btn";
            this.cancelPassword_btn.Size = new System.Drawing.Size(100, 23);
            this.cancelPassword_btn.TabIndex = 29;
            this.cancelPassword_btn.Text = "Cancel";
            this.cancelPassword_btn.UseVisualStyleBackColor = true;
            this.cancelPassword_btn.Visible = false;
            this.cancelPassword_btn.Click += new System.EventHandler(this.cancelPassword_btn_Click);
            // 
            // savePassword_btn
            // 
            this.savePassword_btn.Location = new System.Drawing.Point(4, 143);
            this.savePassword_btn.Name = "savePassword_btn";
            this.savePassword_btn.Size = new System.Drawing.Size(100, 23);
            this.savePassword_btn.TabIndex = 28;
            this.savePassword_btn.Text = "Save password";
            this.savePassword_btn.UseVisualStyleBackColor = true;
            this.savePassword_btn.Visible = false;
            this.savePassword_btn.Click += new System.EventHandler(this.savePassword_btn_Click);
            // 
            // changePassword_btn
            // 
            this.changePassword_btn.Location = new System.Drawing.Point(110, 143);
            this.changePassword_btn.Name = "changePassword_btn";
            this.changePassword_btn.Size = new System.Drawing.Size(100, 23);
            this.changePassword_btn.TabIndex = 27;
            this.changePassword_btn.Text = "Change password";
            this.changePassword_btn.UseVisualStyleBackColor = true;
            this.changePassword_btn.Click += new System.EventHandler(this.changePassword_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(216, 98);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 23);
            this.cancel_btn.TabIndex = 26;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Visible = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // saveData_btn
            // 
            this.saveData_btn.Location = new System.Drawing.Point(4, 98);
            this.saveData_btn.Name = "saveData_btn";
            this.saveData_btn.Size = new System.Drawing.Size(100, 23);
            this.saveData_btn.TabIndex = 25;
            this.saveData_btn.Text = "Save data";
            this.saveData_btn.UseVisualStyleBackColor = true;
            this.saveData_btn.Visible = false;
            this.saveData_btn.Click += new System.EventHandler(this.saveData_btn_Click);
            // 
            // changeData_btn
            // 
            this.changeData_btn.Location = new System.Drawing.Point(110, 98);
            this.changeData_btn.Name = "changeData_btn";
            this.changeData_btn.Size = new System.Drawing.Size(100, 23);
            this.changeData_btn.TabIndex = 24;
            this.changeData_btn.Text = "Change data";
            this.changeData_btn.UseVisualStyleBackColor = true;
            this.changeData_btn.Click += new System.EventHandler(this.changeData_btn_Click);
            // 
            // secondName_lbl
            // 
            this.secondName_lbl.AutoSize = true;
            this.secondName_lbl.Location = new System.Drawing.Point(18, 58);
            this.secondName_lbl.Name = "secondName_lbl";
            this.secondName_lbl.Size = new System.Drawing.Size(86, 13);
            this.secondName_lbl.TabIndex = 23;
            this.secondName_lbl.Text = "SECOND NAME";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(66, 32);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(38, 13);
            this.name_lbl.TabIndex = 22;
            this.name_lbl.Text = "NAME";
            // 
            // secondName_tb
            // 
            this.secondName_tb.Location = new System.Drawing.Point(110, 58);
            this.secondName_tb.Name = "secondName_tb";
            this.secondName_tb.ReadOnly = true;
            this.secondName_tb.Size = new System.Drawing.Size(100, 20);
            this.secondName_tb.TabIndex = 21;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(110, 32);
            this.name_tb.Name = "name_tb";
            this.name_tb.ReadOnly = true;
            this.name_tb.Size = new System.Drawing.Size(100, 20);
            this.name_tb.TabIndex = 20;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(64, 6);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(40, 13);
            this.login_lbl.TabIndex = 18;
            this.login_lbl.Text = "LOGIN";
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(110, 6);
            this.login_tb.Name = "login_tb";
            this.login_tb.ReadOnly = true;
            this.login_tb.Size = new System.Drawing.Size(100, 20);
            this.login_tb.TabIndex = 16;
            // 
            // products_tp
            // 
            this.products_tp.Controls.Add(this.addToBasket_btn);
            this.products_tp.Controls.Add(this.products_dgv);
            this.products_tp.Location = new System.Drawing.Point(4, 22);
            this.products_tp.Name = "products_tp";
            this.products_tp.Padding = new System.Windows.Forms.Padding(3);
            this.products_tp.Size = new System.Drawing.Size(752, 511);
            this.products_tp.TabIndex = 1;
            this.products_tp.Text = "Products";
            this.products_tp.UseVisualStyleBackColor = true;
            // 
            // addToBasket_btn
            // 
            this.addToBasket_btn.Location = new System.Drawing.Point(296, 229);
            this.addToBasket_btn.Name = "addToBasket_btn";
            this.addToBasket_btn.Size = new System.Drawing.Size(157, 23);
            this.addToBasket_btn.TabIndex = 1;
            this.addToBasket_btn.Text = "ADD TO BASKET";
            this.addToBasket_btn.UseVisualStyleBackColor = true;
            this.addToBasket_btn.Click += new System.EventHandler(this.addToBasket_btn_Click);
            // 
            // products_dgv
            // 
            this.products_dgv.AllowUserToAddRows = false;
            this.products_dgv.AllowUserToDeleteRows = false;
            this.products_dgv.AllowUserToResizeColumns = false;
            this.products_dgv.AllowUserToResizeRows = false;
            this.products_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_dgv.Location = new System.Drawing.Point(6, 6);
            this.products_dgv.Name = "products_dgv";
            this.products_dgv.ReadOnly = true;
            this.products_dgv.RowHeadersVisible = false;
            this.products_dgv.Size = new System.Drawing.Size(740, 150);
            this.products_dgv.TabIndex = 0;
            this.products_dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.products_dgv_CellMouseDoubleClick);
            // 
            // basket_tp
            // 
            this.basket_tp.Controls.Add(this.deleteFromBasket_btn);
            this.basket_tp.Controls.Add(this.basket_dgv);
            this.basket_tp.Location = new System.Drawing.Point(4, 22);
            this.basket_tp.Name = "basket_tp";
            this.basket_tp.Padding = new System.Windows.Forms.Padding(3);
            this.basket_tp.Size = new System.Drawing.Size(752, 511);
            this.basket_tp.TabIndex = 2;
            this.basket_tp.Text = "Basket";
            this.basket_tp.UseVisualStyleBackColor = true;
            // 
            // deleteFromBasket_btn
            // 
            this.deleteFromBasket_btn.Location = new System.Drawing.Point(298, 244);
            this.deleteFromBasket_btn.Name = "deleteFromBasket_btn";
            this.deleteFromBasket_btn.Size = new System.Drawing.Size(157, 23);
            this.deleteFromBasket_btn.TabIndex = 2;
            this.deleteFromBasket_btn.Text = "DELETE FROM BASKET";
            this.deleteFromBasket_btn.UseVisualStyleBackColor = true;
            this.deleteFromBasket_btn.Click += new System.EventHandler(this.deleteFromBasket_btn_Click);
            // 
            // basket_dgv
            // 
            this.basket_dgv.AllowUserToAddRows = false;
            this.basket_dgv.AllowUserToDeleteRows = false;
            this.basket_dgv.AllowUserToResizeColumns = false;
            this.basket_dgv.AllowUserToResizeRows = false;
            this.basket_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basket_dgv.Location = new System.Drawing.Point(6, 6);
            this.basket_dgv.Name = "basket_dgv";
            this.basket_dgv.ReadOnly = true;
            this.basket_dgv.RowHeadersVisible = false;
            this.basket_dgv.Size = new System.Drawing.Size(740, 150);
            this.basket_dgv.TabIndex = 1;
            this.basket_dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.basket_dgv_CellMouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.tabControl1.ResumeLayout(false);
            this.userInfo_tp.ResumeLayout(false);
            this.userInfo_tp.PerformLayout();
            this.products_tp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.products_dgv)).EndInit();
            this.basket_tp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basket_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage userInfo_tp;
        private System.Windows.Forms.TabPage products_tp;
        private System.Windows.Forms.Label secondName_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox secondName_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Button changeData_btn;
        private System.Windows.Forms.Button saveData_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button cancelPassword_btn;
        private System.Windows.Forms.Button savePassword_btn;
        private System.Windows.Forms.Button changePassword_btn;
        private System.Windows.Forms.Label confirmPassword_lbl;
        private System.Windows.Forms.Label newPassword_lbl;
        private System.Windows.Forms.TextBox confirmPassword_tb;
        private System.Windows.Forms.TextBox newPassword_tb;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.Label oldPassword_lbl;
        private System.Windows.Forms.TextBox oldPassword_tb;
        private System.Windows.Forms.TextBox saleCard_tb;
        private System.Windows.Forms.Label saleCard_lbl;
        private System.Windows.Forms.Button createSaleCard_btn;
        private System.Windows.Forms.DataGridView products_dgv;
        private System.Windows.Forms.Button addToBasket_btn;
        private System.Windows.Forms.TabPage basket_tp;
        private System.Windows.Forms.DataGridView basket_dgv;
        private System.Windows.Forms.Button deleteFromBasket_btn;
    }
}

