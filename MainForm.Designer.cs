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
            this.components = new System.ComponentModel.Container();
            this.store_tc = new System.Windows.Forms.TabControl();
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
            this.makeAnOrder_btn = new System.Windows.Forms.Button();
            this.deleteFromBasket_btn = new System.Windows.Forms.Button();
            this.basket_dgv = new System.Windows.Forms.DataGridView();
            this.orders_tp = new System.Windows.Forms.TabPage();
            this.orders_dgv = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumThroughputDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interfaceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_bs = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumThroughputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interfaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basket_bs = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orders_bs = new System.Windows.Forms.BindingSource(this.components);
            this.store_tc.SuspendLayout();
            this.userInfo_tp.SuspendLayout();
            this.products_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_dgv)).BeginInit();
            this.basket_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basket_dgv)).BeginInit();
            this.orders_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket_bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_bs)).BeginInit();
            this.SuspendLayout();
            // 
            // store_tc
            // 
            this.store_tc.Controls.Add(this.userInfo_tp);
            this.store_tc.Controls.Add(this.products_tp);
            this.store_tc.Controls.Add(this.basket_tp);
            this.store_tc.Controls.Add(this.orders_tp);
            this.store_tc.Location = new System.Drawing.Point(12, 12);
            this.store_tc.Name = "store_tc";
            this.store_tc.SelectedIndex = 0;
            this.store_tc.Size = new System.Drawing.Size(760, 537);
            this.store_tc.TabIndex = 1;
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
            this.products_dgv.AllowUserToDeleteRows = false;
            this.products_dgv.AllowUserToResizeColumns = false;
            this.products_dgv.AllowUserToResizeRows = false;
            this.products_dgv.AutoGenerateColumns = false;
            this.products_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.products_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.countryDataGridViewTextBoxColumn1,
            this.companyDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.seriesDataGridViewTextBoxColumn1,
            this.memoryDataGridViewTextBoxColumn1,
            this.frequencyDataGridViewTextBoxColumn1,
            this.capacityDataGridViewTextBoxColumn1,
            this.memoryTypeDataGridViewTextBoxColumn1,
            this.maximumThroughputDataGridViewTextBoxColumn1,
            this.interfaceDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.products_dgv.DataSource = this.products_bs;
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
            this.basket_tp.Controls.Add(this.makeAnOrder_btn);
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
            // makeAnOrder_btn
            // 
            this.makeAnOrder_btn.Location = new System.Drawing.Point(298, 287);
            this.makeAnOrder_btn.Name = "makeAnOrder_btn";
            this.makeAnOrder_btn.Size = new System.Drawing.Size(157, 23);
            this.makeAnOrder_btn.TabIndex = 3;
            this.makeAnOrder_btn.Text = "MAKE AN ORDER";
            this.makeAnOrder_btn.UseVisualStyleBackColor = true;
            this.makeAnOrder_btn.Click += new System.EventHandler(this.makeAnOrder_btn_Click);
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
            this.basket_dgv.AutoGenerateColumns = false;
            this.basket_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.basket_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basket_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.memoryDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.memoryTypeDataGridViewTextBoxColumn,
            this.maximumThroughputDataGridViewTextBoxColumn,
            this.interfaceDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.basket_dgv.DataSource = this.basket_bs;
            this.basket_dgv.Location = new System.Drawing.Point(6, 6);
            this.basket_dgv.Name = "basket_dgv";
            this.basket_dgv.ReadOnly = true;
            this.basket_dgv.RowHeadersVisible = false;
            this.basket_dgv.Size = new System.Drawing.Size(740, 150);
            this.basket_dgv.TabIndex = 1;
            this.basket_dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.basket_dgv_CellMouseDoubleClick);
            // 
            // orders_tp
            // 
            this.orders_tp.Controls.Add(this.orders_dgv);
            this.orders_tp.Location = new System.Drawing.Point(4, 22);
            this.orders_tp.Name = "orders_tp";
            this.orders_tp.Padding = new System.Windows.Forms.Padding(3);
            this.orders_tp.Size = new System.Drawing.Size(752, 511);
            this.orders_tp.TabIndex = 3;
            this.orders_tp.Text = "Orders";
            this.orders_tp.UseVisualStyleBackColor = true;
            // 
            // orders_dgv
            // 
            this.orders_dgv.AllowUserToAddRows = false;
            this.orders_dgv.AllowUserToDeleteRows = false;
            this.orders_dgv.AllowUserToResizeColumns = false;
            this.orders_dgv.AllowUserToResizeRows = false;
            this.orders_dgv.AutoGenerateColumns = false;
            this.orders_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orders_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.userIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.orders_dgv.DataSource = this.orders_bs;
            this.orders_dgv.Location = new System.Drawing.Point(6, 6);
            this.orders_dgv.Name = "orders_dgv";
            this.orders_dgv.ReadOnly = true;
            this.orders_dgv.RowHeadersVisible = false;
            this.orders_dgv.Size = new System.Drawing.Size(740, 150);
            this.orders_dgv.TabIndex = 2;
            this.orders_dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orders_dgv_CellMouseDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn1
            // 
            this.countryDataGridViewTextBoxColumn1.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn1.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn1.Name = "countryDataGridViewTextBoxColumn1";
            this.countryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn1
            // 
            this.companyDataGridViewTextBoxColumn1.DataPropertyName = "company";
            this.companyDataGridViewTextBoxColumn1.HeaderText = "company";
            this.companyDataGridViewTextBoxColumn1.Name = "companyDataGridViewTextBoxColumn1";
            this.companyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            this.modelDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // seriesDataGridViewTextBoxColumn1
            // 
            this.seriesDataGridViewTextBoxColumn1.DataPropertyName = "series";
            this.seriesDataGridViewTextBoxColumn1.HeaderText = "series";
            this.seriesDataGridViewTextBoxColumn1.Name = "seriesDataGridViewTextBoxColumn1";
            this.seriesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memoryDataGridViewTextBoxColumn1
            // 
            this.memoryDataGridViewTextBoxColumn1.DataPropertyName = "memory";
            this.memoryDataGridViewTextBoxColumn1.HeaderText = "memory";
            this.memoryDataGridViewTextBoxColumn1.Name = "memoryDataGridViewTextBoxColumn1";
            this.memoryDataGridViewTextBoxColumn1.ReadOnly = true;
            this.memoryDataGridViewTextBoxColumn1.Visible = false;
            // 
            // frequencyDataGridViewTextBoxColumn1
            // 
            this.frequencyDataGridViewTextBoxColumn1.DataPropertyName = "frequency";
            this.frequencyDataGridViewTextBoxColumn1.HeaderText = "frequency";
            this.frequencyDataGridViewTextBoxColumn1.Name = "frequencyDataGridViewTextBoxColumn1";
            this.frequencyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.frequencyDataGridViewTextBoxColumn1.Visible = false;
            // 
            // capacityDataGridViewTextBoxColumn1
            // 
            this.capacityDataGridViewTextBoxColumn1.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn1.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn1.Name = "capacityDataGridViewTextBoxColumn1";
            this.capacityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn1.Visible = false;
            // 
            // memoryTypeDataGridViewTextBoxColumn1
            // 
            this.memoryTypeDataGridViewTextBoxColumn1.DataPropertyName = "memoryType";
            this.memoryTypeDataGridViewTextBoxColumn1.HeaderText = "memoryType";
            this.memoryTypeDataGridViewTextBoxColumn1.Name = "memoryTypeDataGridViewTextBoxColumn1";
            this.memoryTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.memoryTypeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // maximumThroughputDataGridViewTextBoxColumn1
            // 
            this.maximumThroughputDataGridViewTextBoxColumn1.DataPropertyName = "maximumThroughput";
            this.maximumThroughputDataGridViewTextBoxColumn1.HeaderText = "maximumThroughput";
            this.maximumThroughputDataGridViewTextBoxColumn1.Name = "maximumThroughputDataGridViewTextBoxColumn1";
            this.maximumThroughputDataGridViewTextBoxColumn1.ReadOnly = true;
            this.maximumThroughputDataGridViewTextBoxColumn1.Visible = false;
            // 
            // interfaceDataGridViewTextBoxColumn1
            // 
            this.interfaceDataGridViewTextBoxColumn1.DataPropertyName = "Interface";
            this.interfaceDataGridViewTextBoxColumn1.HeaderText = "Interface";
            this.interfaceDataGridViewTextBoxColumn1.Name = "interfaceDataGridViewTextBoxColumn1";
            this.interfaceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.interfaceDataGridViewTextBoxColumn1.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // products_bs
            // 
            this.products_bs.AllowNew = false;
            this.products_bs.DataSource = typeof(Store_kurs.Product);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "series";
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            this.seriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memoryDataGridViewTextBoxColumn
            // 
            this.memoryDataGridViewTextBoxColumn.DataPropertyName = "memory";
            this.memoryDataGridViewTextBoxColumn.HeaderText = "memory";
            this.memoryDataGridViewTextBoxColumn.Name = "memoryDataGridViewTextBoxColumn";
            this.memoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "frequency";
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            this.frequencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.frequencyDataGridViewTextBoxColumn.Visible = false;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Visible = false;
            // 
            // memoryTypeDataGridViewTextBoxColumn
            // 
            this.memoryTypeDataGridViewTextBoxColumn.DataPropertyName = "memoryType";
            this.memoryTypeDataGridViewTextBoxColumn.HeaderText = "memoryType";
            this.memoryTypeDataGridViewTextBoxColumn.Name = "memoryTypeDataGridViewTextBoxColumn";
            this.memoryTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoryTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // maximumThroughputDataGridViewTextBoxColumn
            // 
            this.maximumThroughputDataGridViewTextBoxColumn.DataPropertyName = "maximumThroughput";
            this.maximumThroughputDataGridViewTextBoxColumn.HeaderText = "maximumThroughput";
            this.maximumThroughputDataGridViewTextBoxColumn.Name = "maximumThroughputDataGridViewTextBoxColumn";
            this.maximumThroughputDataGridViewTextBoxColumn.ReadOnly = true;
            this.maximumThroughputDataGridViewTextBoxColumn.Visible = false;
            // 
            // interfaceDataGridViewTextBoxColumn
            // 
            this.interfaceDataGridViewTextBoxColumn.DataPropertyName = "Interface";
            this.interfaceDataGridViewTextBoxColumn.HeaderText = "Interface";
            this.interfaceDataGridViewTextBoxColumn.Name = "interfaceDataGridViewTextBoxColumn";
            this.interfaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.interfaceDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basket_bs
            // 
            this.basket_bs.DataSource = typeof(Store_kurs.Product);
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orders_bs
            // 
            this.orders_bs.DataSource = typeof(Store_kurs.Order);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.store_tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.store_tc.ResumeLayout(false);
            this.userInfo_tp.ResumeLayout(false);
            this.userInfo_tp.PerformLayout();
            this.products_tp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.products_dgv)).EndInit();
            this.basket_tp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basket_dgv)).EndInit();
            this.orders_tp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orders_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket_bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl store_tc;
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
        private System.Windows.Forms.Button makeAnOrder_btn;
        private System.Windows.Forms.BindingSource products_bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumThroughputDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn interfaceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumThroughputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interfaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource basket_bs;
        private System.Windows.Forms.TabPage orders_tp;
        private System.Windows.Forms.DataGridView orders_dgv;
        private System.Windows.Forms.BindingSource orders_bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

